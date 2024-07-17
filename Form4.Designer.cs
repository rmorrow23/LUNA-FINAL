namespace Moonbase
{
    partial class LogViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewerForm));
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.ItemHeight = 25;
            this.listBoxLogs.Location = new System.Drawing.Point(187, 88);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(1060, 654);
            this.listBoxLogs.TabIndex = 0;
            // 
            // LogViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase.Properties.Resources.Dark_GUI_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1633, 908);
            this.Controls.Add(this.listBoxLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogViewerForm";
            this.Text = "Location Logs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogs;
    }
}