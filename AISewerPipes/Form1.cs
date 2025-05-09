using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using Guna.UI2.WinForms; // Guna ProgressBar
#pragma warning disable CS0105 // The using directive for 'System.Windows.Forms' appeared previously in this namespace
#pragma warning restore CS0105 // The using directive for 'System.Windows.Forms' appeared previously in this namespace
#pragma warning disable CS0105 // The using directive for 'System.Windows.Forms' appeared previously in this namespace
#pragma warning restore CS0105 // The using directive for 'System.Windows.Forms' appeared previously in this namespace

namespace AISewerPipes
{
	public partial class Form1 : Form
	{
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Map tab names to panels (tabs)
        private Dictionary<string, Control> tabs = new Dictionary<string, Control>();

        // Map tab names to panels (tabs)
        private Dictionary<string, Guna2TileButton> tabsButton= new Dictionary<string, Guna2TileButton>();

        // Track current tab name
        private string currentTabName;

        public Form1()
		{
			InitializeComponent();
            browseButton.Click += BrowseButton_Click;
            PlusImageButton.Click += BrowseButton_Click;
        }
        public class ProgressLog
        {
            public double progress { get; set; }
            public string current_stage { get; set; }
            public Dictionary<string, Stage> stages { get; set; }
        }

        public class Stage
        {
            public int weight { get; set; }
            public double progress { get; set; }
            public string status { get; set; }
            public Dictionary<string, object> details { get; set; }  // can hold dynamic data
        }
        // Utility function to check for common video extensions
        private bool IsVideoFile(string filePath)
        {
            string[] videoExtensions = { ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv", ".webm", ".mpg" };
            string extension = Path.GetExtension(filePath).ToLower();

            return videoExtensions.Contains(extension);
        }
        private void PlusImageButton_DragDrop(object sender, DragEventArgs e)
        {
            // Get the files dropped
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0 && IsVideoFile(files[0]))
            {
                BrowseTextbox.Text = files[0]; // Set video path in textbox
            }
        }

        private void PlusImageButton_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data being dragged is a file (and allow copy effect)
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Optional - only allow video files
                if (files.Length > 0 && IsVideoFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None; // Not allowed
                }
            }
            PlusImageButton.Image = AISewerPipes.Properties.Resources.correct;
            PlusImageButton.ImageSize = new Size(50, 50);

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileAndSetPath();
            PlusImageButton.Image = AISewerPipes.Properties.Resources.correct;
            PlusImageButton.ImageSize = new Size(50, 50);
        }

        private void OpenFileAndSetPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Video files (*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.mpg)|*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.mpg";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;
                openFileDialog.Multiselect = true; // Allow multiple file selection

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] filePaths = openFileDialog.FileNames; // Get all selected file paths
                    BrowseTextbox.Text = string.Join("; ", filePaths); // Display paths separated by semicolons
                }
            }
        }
        private void ShowSpecificTab(Control tabToShow)
        {
            // List of all tabs (you can add all your tab controls here)
            Control[] allTabs = { InputsTab, UploadTab, AiDetectorTab };

            // Hide all tabs first
            foreach (var tab in allTabs)
            {
                tab.Hide();
            }

            // Show the desired tab
            tabToShow.Show();
            currentTabName = tabToShow.Name;

            bool hasPreviousTab = GetPreviousTabName(currentTabName) != null;
            bool hasNextTab = GetNextTabName(currentTabName) != null;

            BackButton.Visible = hasPreviousTab;
            NextButton.Visible = hasNextTab;

            // Position logic
            if (hasPreviousTab && hasNextTab)
            {
                BackButton.Location = new Point(328, 30);
                NextButton.Location = new Point(748, 30);
            }
            else if (hasPreviousTab) // Only BackButton is visible
            {
                BackButton.Location = new Point(537, 30);
            }
            else if (hasNextTab) // Only NextButton is visible
            {
                NextButton.Location = new Point(537, 30);
            }

        }

        private void ChangeSpecificColor(Guna2TileButton MainButton)
        {
            // List of all tabs (you can add all your tab controls here)
            Guna2TileButton[] allButtons = { AIdetectroButton, inputButton, UploadButton , ProgressTemp };
            Color defaultColor = Color.FromArgb(10, 10, 10);
            Color GreenColor = Color.FromArgb(150, 0, 200, 83);

            foreach (var Button in allButtons)
            {
                Button.FillColor = defaultColor;
            }
            MainButton.FillColor = GreenColor;
        }

        private void ProgressTemp_Click(object sender, EventArgs e)
        {
            ChangeSpecificColor(ProgressTemp);
            ShowSpecificTab(ProgressbarTab);
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            ChangeSpecificColor(UploadButton);
            ShowSpecificTab(UploadTab);
        }
        private void inputButton_Click(object sender, EventArgs e)
        {
            ChangeSpecificColor(inputButton);
            ShowSpecificTab(InputsTab);
        }
        private void AIdetectroButton_Click(object sender, EventArgs e)
        {
            ChangeSpecificColor(AIdetectroButton);
            ShowSpecificTab(AiDetectorTab);
            currentTabName = "AiDetectorTab";

            VidePathLabel.Text = Path.GetFileName(BrowseTextbox.Text) == "" ? "Upload your video file": "Video path : " + Path.GetFileName(BrowseTextbox.Text); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the map - assign each tab a unique name
            tabs.Add("InputsTab", InputsTab);
            tabs.Add("UploadTab", UploadTab);
            tabs.Add("AiDetectorTab", AiDetectorTab);
            tabs.Add("ProgressbarTab", ProgressbarTab);

            // Initialize the map - assign each tab a unique name
            tabsButton.Add("InputsTab", inputButton);
            tabsButton.Add("UploadTab", UploadButton);
            tabsButton.Add("AiDetectorTab", AIdetectroButton);
            tabsButton.Add("ProgressbarTab", ProgressTemp);


            // Start on the first tab (InputsTab)
            ShowTab("InputsTab");

        }
        // Helper method to show a specific tab by index
        private void ShowTab(string tabName)
        {
            foreach (var tab in tabs.Values)
            {
                tab.Hide();
            }

            if (tabs.ContainsKey(tabName))
            {
                tabs[tabName].Show();
                currentTabName = tabName;
            }

            // Optional - control enabling/disabling buttons based on position
            bool hasPreviousTab = GetPreviousTabName(currentTabName) != null;
            bool hasNextTab = GetNextTabName(currentTabName) != null;

            BackButton.Visible = hasPreviousTab;
            NextButton.Visible = hasNextTab;

            // Position logic
            if (hasPreviousTab && hasNextTab)
            {
                BackButton.Location = new Point(328, 30);
                NextButton.Location = new Point(748, 30);
            }
            else if (hasPreviousTab) // Only BackButton is visible
            {
                BackButton.Location = new Point(537, 30);
            }
            else if (hasNextTab) // Only NextButton is visible
            {
                NextButton.Location = new Point(537, 30);
            }
        }
        
        private string GetNextTabName(string current)
        {
            var keys = tabs.Keys.ToList();
            int index = keys.IndexOf(current);
            if (index >= 0 && index < keys.Count - 2)
            {
                return keys[index + 1];
            }
            return null;
        }

        // Get the previous tab name based on current order
        private string GetPreviousTabName(string current)
        {
            var keys = tabs.Keys.ToList();
            int index = keys.IndexOf(current);
            if (index > 0)
            {
                return keys[index - 1];
            }
            return null;
        }

        // Handle Next button click
        private void NextButton_Click(object sender, EventArgs e)
        {

            string nextTab = GetNextTabName(currentTabName);
            if (nextTab != null)
            {
                if (nextTab == "AiDetectorTab")
                {
                    if (BrowseTextbox.Text == "")
                    {
                        Guna.UI2.WinForms.Guna2MessageDialog messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog
                        {
                            Caption = "Upload Required",
                            Text = "Please upload a video file before proceeding.",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning,
                            Style = MessageDialogStyle.Dark
                        };
                        messageDialog.Parent = this;
                        // Show the message
                        messageDialog.Show();
                        return;
                    }
                }

                if (BrowseTextbox.Text != "")
                {
                    AIdetectroButton.Enabled = true;
                    VidePathLabel.Text = Path.GetFileName(BrowseTextbox.Text);
                }
                    
                ChangeSpecificColor(tabsButton[nextTab]);
                ShowTab(nextTab);
 
            }
        }

        // Handle Back button click
        private void BackButton_Click(object sender, EventArgs e)
        {
            string previousTab = GetPreviousTabName(currentTabName);
            if (previousTab != null)
            {
                if (previousTab == "AiDetectorTab")
                {
                    VidePathLabel.Text = Path.GetFileName(BrowseTextbox.Text);
                }

                ChangeSpecificColor(tabsButton[previousTab]);
                ShowTab(previousTab);
            }
        }

        string GetGlobalPythonPath()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "where",
                    Arguments = "python",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Return the first result
                    string[] paths = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    if (paths.Length > 0 && File.Exists(paths[0]))
                    {
                        return paths[0];
                    }
                }
            }
            catch
            {
                // Ignore and return null
            }

            return null;
        }
        public static void ReadJsonFile(string filePath)
        {
            try
            {
                // Read the JSON file content
                string jsonContent = File.ReadAllText(filePath);

                // Parse the JSON content into a dynamic object
                var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonContent);

                // Example: Print the JSON content
                Console.WriteLine(jsonObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        private void StartAIdetectorButton_Click(object sender, EventArgs e)
        {

            // Read JSON file
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "progress_log.json");
            if (File.Exists(filePath))
            {
                string jsonText = File.ReadAllText(filePath);
                var progressData = JsonConvert.DeserializeObject<ProgressLog>(jsonText);
                progressData.current_stage = "initialization";
                progressData.progress = 0;
                // Serialize the object back to JSON
                string updatedJsonText = JsonConvert.SerializeObject(progressData, Formatting.Indented);

                // Write the updated JSON back to the file
                File.WriteAllText(filePath, updatedJsonText);
            }
                // Get the video path from the TextBox
            string videoPath = BrowseTextbox.Text;

            // Get the directory where the executable is running
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            exeDirectory = Directory.GetParent(exeDirectory).Parent.FullName;

            // Path to your Python script (assumed to be beside the exe)
            string pythonScriptPath = Path.Combine(exeDirectory, "Analyser_Batch.py");

            // Path to the Python interpreter inside the `.venv\Scripts\python.exe` beside the exe
            string PyPrimaryPath = Directory.GetParent(exeDirectory).Parent.FullName;
            PyPrimaryPath = Path.Combine(PyPrimaryPath, ".venv", "Scripts", "python.exe");

            string globalPyPath = GetGlobalPythonPath();


            string pythonInterpreterPath = null;
            //pythonInterpreterPath = @"C:\Users\water active\AppData\Local\Programs\Python\Python310\python.exe";

            if (File.Exists(PyPrimaryPath))
            {
                pythonInterpreterPath = PyPrimaryPath;
            }
            else if (File.Exists(globalPyPath))
            {
                pythonInterpreterPath = globalPyPath;
            }
            else
            {
                pythonInterpreterPath = GetGlobalPythonPath();
            }
            pythonInterpreterPath = @"C:\Users\sobha\Desktop\detectron2\Code\.venv\Scripts\python.exe";
            pythonScriptPath = @"C:\Users\sobha\Desktop\detectron2\Code\Auto_Sewer_Document\Analyser_Batch.py";

            Console.WriteLine(pythonInterpreterPath);
            
            if (string.IsNullOrEmpty(videoPath))
            {
                MessageBox.Show("Please provide a valid video path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.IO.File.Exists(pythonInterpreterPath))
            {
                MessageBox.Show("Python script file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                ProgressTemp.Enabled = true;
                ChangeSpecificColor(ProgressTemp);
                ShowSpecificTab(ProgressbarTab);
                Timer timer = new Timer();
                timer.Interval = 1000; // Every 1 seconds
                timer.Tick += (s, ev) => UpdateProgressBar(CircleProgressBar, ProgressBarlable);
                timer.Start();

                // Create a new process to run the Python script
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = pythonInterpreterPath,
                    Arguments = $"\"{pythonScriptPath}\" \"{videoPath}\"", // Pass the script path and the video file path
                    UseShellExecute = true,      // Must be true to allow shell window
                    CreateNoWindow = false       // Allow window to be shown
                };

                // Start the process
                Process process = Process.Start(processInfo);

                // Optional: Inform user that the process has started
                MessageBox.Show("Python script is running in the background.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);







            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void UpdateProgressBar(Guna2CircleProgressBar progressBar, Label statusLabel)
        {
            try
            {
                // Define colors
                Color activeColor = Color.Red;                      // Active stage color (optional)
                Color completedColor = Color.FromArgb(0, 200, 83);  // Completed stage color (green)
                Color defaultColor = Color.FromArgb(60, 60, 60);    // Default inactive color (gray)

                // Ordered stages (circle buttons)
                List<(string StageName, Guna2CircleButton CircleButton)> stageList = new List<(string, Guna2CircleButton)>
                {
                    ("initialization", InitilizeCircleProgress),
                    ("frame extraction", frameExtractionCricleProgress),
                    ("Ai detection", AiDetectionCircleProgress),
                    ("text extraction", textExtractionCircleProgress),
                    ("excel reporting", excelReportingCircleProgress)
                };

                // Ordered lines (MaterialDivider) between stages
                List<(string StageName, MaterialDivider DeviderLine)> stageLineList = new List<(string, MaterialDivider)>
                {
                    ("frame extraction", frameExtractionLineProgress),
                    ("Ai detection", AidetectionLineProgress),
                    ("text extraction", textExtractionLineProgress),
                    ("excel reporting", excelReportingLineProgress)
                };


                Dictionary<string, string> StageBaseName = new Dictionary<string, string>
                {
                    { "initialization", "1" },
                    { "frame extraction", "2" },
                    { "Ai detection", "AI" },
                    { "text extraction", "3" },
                    { "excel reporting", "4" }
                };

                // Read JSON file
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "progress_log.json");
                if (File.Exists(filePath))
                {
                    string jsonText = File.ReadAllText(filePath);
                    var progressData = JsonConvert.DeserializeObject<ProgressLog>(jsonText);

                    if (progressData != null)
                    {
                        // Update progress bar and label
                        progressBar.Value = (int)progressData.progress;
                        statusLabel.Text = $"Stage: {progressData.current_stage} | Progress: {progressData.progress}%";

                        // Set all circles and dividers to default (gray)
                        foreach (var (stageName, circleButton) in stageList)
                        {
                            circleButton.BorderColor = defaultColor;
                            circleButton.Text = StageBaseName[stageName];
                            circleButton.Image = null;
                            circleButton.ForeColor = Color.White;
                        }
                        foreach (var (stageName, dividerLine) in stageLineList)
                        {
                            dividerLine.BackColor = defaultColor;
                        }

                        // Find the index of the current stage
                        int currentStageIndex = stageList.FindIndex(s => s.StageName == progressData.current_stage);
                        // Calculate center point before resizing


                        // Set all previous stages (including current) to completedColor
                        for (int i = 0; i <= currentStageIndex; i++)
                        {
                            var circleButton = stageList[i].CircleButton;
                            Point center = new Point(circleButton.Left + circleButton.Width / 2, circleButton.Top + circleButton.Height / 2);

                            stageList[i].CircleButton.BorderColor = completedColor;
                            stageList[i].CircleButton.ForeColor = completedColor;

                            // Set size to a fixed "highlight" size, rather than multiplying it
                            if (i == currentStageIndex)
                            {
                                // Current stage - larger size
                                circleButton.Size = new Size(60, 60);
                                circleButton.BorderColor = completedColor;
                                circleButton.ForeColor = completedColor;
                                circleButton.Image = null;  // No image for current stage
                                CircleProgressLable.Text = progressData.current_stage;
                                CircleProgressLable.Location = new Point(center.X - 75, center.Y + (circleButton.Height / 2) + 5);


                            }
                            else
                            {
                                // Completed stages - smaller size with checkmark
                                circleButton.Size = new Size(45, 45);
                                circleButton.BorderColor = completedColor;
                                circleButton.ForeColor = completedColor;
                                circleButton.Text = "";

                                // Set completed stage icon
                                circleButton.Image = Properties.Resources.correct;
                                circleButton.ImageSize = new Size(20, 20);
                                circleButton.ImageOffset = new Point(1, 0);
                            }
                            // After resizing, reposition to keep the center in the same place
                            circleButton.Left = center.X - circleButton.Width / 2;
                            circleButton.Top = center.Y - circleButton.Height / 2;

                        }

                        // Set lines between **completed stages** to completedColor
                        // Lines connect previous stage to next stage, so if `frame extraction` is completed, its line should be green
                        for (int i = 0; i < stageLineList.Count; i++)
                        {
                            if (i < currentStageIndex)
                            {
                                stageLineList[i].DeviderLine.BackColor = completedColor;
                            }
                            else
                            {
                                stageLineList[i].DeviderLine.BackColor = defaultColor;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading JSON: " + ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        Timer borderRadiusTimer = new Timer();
        int targetBorderRadius = 27;  // Desired radius
        int animationStep = 2;  // Step per timer tick

        private void StartAIdetectorButton_MouseEnter(object sender, EventArgs e)
        {
            borderRadiusTimer.Stop();  // In case it's running already
            borderRadiusTimer = new Timer();
            borderRadiusTimer.Interval = 5;  // Speed of animation (lower is faster)
            borderRadiusTimer.Tick += (s, ev) =>
            {
                if (StartAIdetectorButton.BorderRadius <= targetBorderRadius)
                {
                    StartAIdetectorButton.BorderRadius += animationStep;
                }
                else
                {
                    borderRadiusTimer.Stop();
                }
            };

            borderRadiusTimer.Start();
        }

        private void StartAIdetectorButton_MouseLeave(object sender, EventArgs e)
        {
            borderRadiusTimer.Stop();
            borderRadiusTimer = new Timer();
            borderRadiusTimer.Interval = 5;
            borderRadiusTimer.Tick += (s, ev) =>
            {
                if (StartAIdetectorButton.BorderRadius >= 6)  // Original size
                {
                    StartAIdetectorButton.BorderRadius -= animationStep;
                }
                else
                {
                    borderRadiusTimer.Stop();
                }
            };

            borderRadiusTimer.Start();
        }
    }
}
