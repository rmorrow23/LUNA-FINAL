using System.Windows.Forms;

namespace Moonbase
{
    partial class Welcome
    {
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private TextBox tbName;
        private Button btnStart;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(-5, 1);
            this.webView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1613, 881);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbName.Location = new System.Drawing.Point(24, 72);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(333, 44);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 158);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(378, 82);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Lets Go!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(609, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 240);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Your First Name:";
            this.groupBox1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.ForeColor = System.Drawing.Color.BlueViolet;
            this.progressBar1.Location = new System.Drawing.Point(590, 803);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(415, 26);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatus.Location = new System.Drawing.Point(717, 769);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 31);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImage = global::Moonbase.Properties.Resources.luna_final;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Moonbase.Properties.Resources.luna_final;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(576, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label lblStatus;
    }
}
