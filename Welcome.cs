using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Threading.Tasks;
using System.Drawing;

namespace Moonbase
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            
        }

        

        private async void Welcome_Load(object sender, EventArgs e)
        {
            // Ensure the WebView2 environment is initialized
            await webView.EnsureCoreWebView2Async(null);

            // Navigate to the video URL
            webView.CoreWebView2.Navigate("http://morrowindustries.c1.biz/Video.html");

            // Inject JavaScript to play the video automatically and ensure audio is unmuted
            webView.CoreWebView2.NavigationCompleted += WebView_NavigationCompleted;

            // Listen for script messages
            webView.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            var script = @"
                var video = document.querySelector('video');
                if (video) {
                    video.muted = false;
                    video.play();
                    video.addEventListener('ended', function() {
                        window.chrome.webview.postMessage('videoEnded');
                    });
                }
            ";
            webView.CoreWebView2.ExecuteScriptAsync(script);
        }

        private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            if (e.TryGetWebMessageAsString() == "videoEnded")
            {
                OnVideoEnded();
            }
        }

        private void OnVideoEnded()
        {
            // Code to execute when the video ends
            // Set inputs to visible
            pictureBox1.Visible = true;
            groupBox1.Visible = true;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();

            // Validate the name
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("The name must contain only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set status label and progress bar to visible
            progressBar1.Visible = true;
            lblStatus.Visible = true;

            // Initialize progress bar and status label
            progressBar1.Value = 0;
            lblStatus.Text = "Saving to user file";

            // Store the name from the TextBox into a text file
            StoreNameToFile(name);

            // Simulate a delay to show progress
            await SimulateProgress();

            MessageBox.Show("Welcome to LUNA, " + name);
            FormMain frm = new FormMain();
            this.Hide();
            frm.Show();
        }

        private async Task SimulateProgress()
        {
            for (int i = 0; i <= 100; i += 10)
            {
                await Task.Delay(500); // Simulate delay
                this.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = i;
                    if (i == 50)
                    {
                        lblStatus.Text = "Finishing Up";
                    }
                    else if (i == 100)
                    {
                        lblStatus.Text = "Completed";
                    }
                });
            }
        }

        private void StoreNameToFile(string name)
        {
            string filePath = "name.txt";

            try
            {
                // Write the name to the file
                File.WriteAllText(filePath, name);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving name: {ex.Message}");
            }
        }

        private void ReadNameFromFile()
        {
            string filePath = "name.txt";

            try
            {
                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read the name from the file
                    string name = File.ReadAllText(filePath);
                    // Display the name in the TextBox
                    tbName.Text = name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading name: {ex.Message}");
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
