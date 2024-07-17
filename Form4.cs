using System;
using System.IO;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class LogViewerForm : Form
    {
        private string logFilePath = "user_location_log.txt";

        public LogViewerForm()
        {
            InitializeComponent();
            LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                if (File.Exists(logFilePath))
                {
                    var logEntries = File.ReadAllLines(logFilePath);
                    foreach (var entry in logEntries)
                    {
                        listBoxLogs.Items.Add(entry);
                    }
                }
                else
                {
                    MessageBox.Show("Log file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
