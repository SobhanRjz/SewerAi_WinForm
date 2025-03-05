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

        // Track current tab name
        private string currentTabName;

        public Form1()
		{
			InitializeComponent();
            browseButton.Click += BrowseButton_Click;
            PlusImageButton.Click += BrowseButton_Click;
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

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileAndSetPath();
            PlusImageButton.Image = AISewerPipes.Properties.Resources.correct;
        }

        private void OpenFileAndSetPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Video files (*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.mpg)|*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.mpg";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    BrowseTextbox.Text = filePath;
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
                BackButton.Location = new Point(192, 31);
                NextButton.Location = new Point(524, 31);
            }
            else if (hasPreviousTab) // Only BackButton is visible
            {
                BackButton.Location = new Point(362, 20);
            }
            else if (hasNextTab) // Only NextButton is visible
            {
                NextButton.Location = new Point(362, 20);
            }

        }
        private void UploadButton_Click(object sender, EventArgs e)
        {
            ShowSpecificTab(UploadTab);
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            ShowSpecificTab(InputsTab);
        }
        private void AIdetectroButton_Click(object sender, EventArgs e)
        {
            ShowSpecificTab(AiDetectorTab);
            currentTabName = "AiDetectorTab";
            VidePathLabel.Text = BrowseTextbox.Text == "" ? "Upload your video file": "Video path : " + BrowseTextbox.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the map - assign each tab a unique name
            tabs.Add("InputsTab", InputsTab);
            tabs.Add("UploadTab", UploadTab);
            tabs.Add("AiDetectorTab", AiDetectorTab);

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
                BackButton.Location = new Point(192, 31);
                NextButton.Location = new Point(524, 31);
            }
            else if (hasPreviousTab) // Only BackButton is visible
            {
                BackButton.Location = new Point(362, 20);
            }
            else if (hasNextTab) // Only NextButton is visible
            {
                NextButton.Location = new Point(362, 20);
            }
        }
        
        private string GetNextTabName(string current)
        {
            var keys = tabs.Keys.ToList();
            int index = keys.IndexOf(current);
            if (index >= 0 && index < keys.Count - 1)
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
                ShowTab(nextTab);
            }
        }

        // Handle Back button click
        private void BackButton_Click(object sender, EventArgs e)
        {
            string previousTab = GetPreviousTabName(currentTabName);
            if (previousTab != null)
            {
                ShowTab(previousTab);
            }
        }

        private void StartAIdetectorButton_Click(object sender, EventArgs e)
        {
            // Get the video path from the TextBox
            string videoPath = BrowseTextbox.Text;

            // Get the directory where the executable is running
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Path to your Python script (assumed to be beside the exe)
            string pythonScriptPath = Path.Combine(exeDirectory, "DetectDefets_Main.py");

            // Path to the Python interpreter inside the `.venv\Scripts\python.exe` beside the exe
            string pythonInterpreterPath = Path.Combine(exeDirectory, ".venv", "Scripts", "python.exe");
            pythonInterpreterPath = @"C:\Users\sobha\Desktop\detectron2\Code\.venv\Scripts\python.exe";
            pythonScriptPath = @"C:\Users\sobha\Desktop\detectron2\Code\Auto_Sewer_Document\Analyser_Batch.py";

            if (string.IsNullOrEmpty(videoPath) || !System.IO.File.Exists(videoPath))
            {
                MessageBox.Show("Please provide a valid video path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.IO.File.Exists(pythonScriptPath))
            {
                MessageBox.Show("Python script file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create a new process to run the Python script
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = pythonInterpreterPath,
                    Arguments = $"\"{pythonScriptPath}\" \"{videoPath}\"", // Pass the script path and the video file path
                    RedirectStandardOutput = false, // No need to redirect output
                    RedirectStandardError = false, // No need to redirect standard error
                    UseShellExecute = true, // Use shell execute to hide the command window
                    CreateNoWindow = false // No window is needed
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
