namespace Moonbase
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GRBXLocationInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLRoomDesc = new System.Windows.Forms.Label();
            this.TXBXRoomDesc = new System.Windows.Forms.TextBox();
            this.TBRoomName = new System.Windows.Forms.TextBox();
            this.personalNav = new System.Windows.Forms.GroupBox();
            this.livingQtBTN = new System.Windows.Forms.Button();
            this.medBayBTN = new System.Windows.Forms.Button();
            this.btnMovie = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnEntertain = new System.Windows.Forms.Button();
            this.LobbyBTN = new System.Windows.Forms.Button();
            this.commandCenterBTN = new System.Windows.Forms.Button();
            this.labBTN = new System.Windows.Forms.Button();
            this.btnHallway = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userLBL = new System.Windows.Forms.Label();
            this.btnTicTacToe = new System.Windows.Forms.Button();
            this.btnNumberGuess = new System.Windows.Forms.Button();
            this.btnLocationLog = new System.Windows.Forms.Button();
            this.GRBXLocationInfo.SuspendLayout();
            this.personalNav.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRBXLocationInfo
            // 
            this.GRBXLocationInfo.BackColor = System.Drawing.Color.Silver;
            this.GRBXLocationInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GRBXLocationInfo.Controls.Add(this.label1);
            this.GRBXLocationInfo.Controls.Add(this.LBLRoomDesc);
            this.GRBXLocationInfo.Controls.Add(this.TXBXRoomDesc);
            this.GRBXLocationInfo.Controls.Add(this.TBRoomName);
            this.GRBXLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBXLocationInfo.ForeColor = System.Drawing.Color.Black;
            this.GRBXLocationInfo.Location = new System.Drawing.Point(13, 378);
            this.GRBXLocationInfo.Margin = new System.Windows.Forms.Padding(4);
            this.GRBXLocationInfo.Name = "GRBXLocationInfo";
            this.GRBXLocationInfo.Padding = new System.Windows.Forms.Padding(4);
            this.GRBXLocationInfo.Size = new System.Drawing.Size(664, 907);
            this.GRBXLocationInfo.TabIndex = 0;
            this.GRBXLocationInfo.TabStop = false;
            this.GRBXLocationInfo.Text = "Location Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name";
            // 
            // LBLRoomDesc
            // 
            this.LBLRoomDesc.AutoSize = true;
            this.LBLRoomDesc.BackColor = System.Drawing.Color.Silver;
            this.LBLRoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRoomDesc.ForeColor = System.Drawing.Color.Black;
            this.LBLRoomDesc.Location = new System.Drawing.Point(24, 292);
            this.LBLRoomDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLRoomDesc.Name = "LBLRoomDesc";
            this.LBLRoomDesc.Size = new System.Drawing.Size(406, 55);
            this.LBLRoomDesc.TabIndex = 2;
            this.LBLRoomDesc.Text = "Room Description";
            this.LBLRoomDesc.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXBXRoomDesc
            // 
            this.TXBXRoomDesc.BackColor = System.Drawing.Color.Silver;
            this.TXBXRoomDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBXRoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBXRoomDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXBXRoomDesc.Location = new System.Drawing.Point(24, 340);
            this.TXBXRoomDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TXBXRoomDesc.Multiline = true;
            this.TXBXRoomDesc.Name = "TXBXRoomDesc";
            this.TXBXRoomDesc.ReadOnly = true;
            this.TXBXRoomDesc.Size = new System.Drawing.Size(612, 463);
            this.TXBXRoomDesc.TabIndex = 3;
            // 
            // TBRoomName
            // 
            this.TBRoomName.BackColor = System.Drawing.Color.Silver;
            this.TBRoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRoomName.Location = new System.Drawing.Point(36, 163);
            this.TBRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.TBRoomName.Name = "TBRoomName";
            this.TBRoomName.ReadOnly = true;
            this.TBRoomName.Size = new System.Drawing.Size(600, 37);
            this.TBRoomName.TabIndex = 1;
            this.TBRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBRoomName.TextChanged += new System.EventHandler(this.TBRoomName_TextChanged);
            // 
            // personalNav
            // 
            this.personalNav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.personalNav.BackColor = System.Drawing.Color.Transparent;
            this.personalNav.BackgroundImage = global::Moonbase.Properties.Resources.map1;
            this.personalNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personalNav.Controls.Add(this.livingQtBTN);
            this.personalNav.Controls.Add(this.medBayBTN);
            this.personalNav.Controls.Add(this.btnMovie);
            this.personalNav.Controls.Add(this.btnCafe);
            this.personalNav.Controls.Add(this.btnEntertain);
            this.personalNav.Controls.Add(this.LobbyBTN);
            this.personalNav.Controls.Add(this.commandCenterBTN);
            this.personalNav.Controls.Add(this.labBTN);
            this.personalNav.Controls.Add(this.btnHallway);
            this.personalNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalNav.ForeColor = System.Drawing.Color.Black;
            this.personalNav.Location = new System.Drawing.Point(839, 106);
            this.personalNav.Margin = new System.Windows.Forms.Padding(6);
            this.personalNav.Name = "personalNav";
            this.personalNav.Padding = new System.Windows.Forms.Padding(6);
            this.personalNav.Size = new System.Drawing.Size(765, 887);
            this.personalNav.TabIndex = 1;
            this.personalNav.TabStop = false;
            this.personalNav.Text = "Personal Nav Device";
            // 
            // livingQtBTN
            // 
            this.livingQtBTN.BackgroundImage = global::Moonbase.Properties.Resources.Living_ICON;
            this.livingQtBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.livingQtBTN.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.livingQtBTN.FlatAppearance.BorderSize = 0;
            this.livingQtBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.livingQtBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livingQtBTN.ForeColor = System.Drawing.Color.Transparent;
            this.livingQtBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.livingQtBTN.Location = new System.Drawing.Point(515, 82);
            this.livingQtBTN.Margin = new System.Windows.Forms.Padding(6);
            this.livingQtBTN.Name = "livingQtBTN";
            this.livingQtBTN.Size = new System.Drawing.Size(161, 186);
            this.livingQtBTN.TabIndex = 2;
            this.livingQtBTN.UseVisualStyleBackColor = true;
            this.livingQtBTN.Click += new System.EventHandler(this.livingQtBTN_Click);
            // 
            // medBayBTN
            // 
            this.medBayBTN.BackgroundImage = global::Moonbase.Properties.Resources.Medbay_ICON;
            this.medBayBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.medBayBTN.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.medBayBTN.FlatAppearance.BorderSize = 0;
            this.medBayBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medBayBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medBayBTN.ForeColor = System.Drawing.Color.Transparent;
            this.medBayBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medBayBTN.Location = new System.Drawing.Point(94, 82);
            this.medBayBTN.Margin = new System.Windows.Forms.Padding(6);
            this.medBayBTN.Name = "medBayBTN";
            this.medBayBTN.Size = new System.Drawing.Size(174, 161);
            this.medBayBTN.TabIndex = 3;
            this.medBayBTN.UseVisualStyleBackColor = true;
            this.medBayBTN.Click += new System.EventHandler(this.medBayBTN_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.BackgroundImage = global::Moonbase.Properties.Resources.movie_icon;
            this.btnMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Location = new System.Drawing.Point(504, 546);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(161, 163);
            this.btnMovie.TabIndex = 8;
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.BackgroundImage = global::Moonbase.Properties.Resources.Cafe_icon;
            this.btnCafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCafe.FlatAppearance.BorderSize = 0;
            this.btnCafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCafe.Location = new System.Drawing.Point(613, 324);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(152, 148);
            this.btnCafe.TabIndex = 7;
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btnCafe_Click);
            // 
            // btnEntertain
            // 
            this.btnEntertain.BackgroundImage = global::Moonbase.Properties.Resources.entertain;
            this.btnEntertain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntertain.FlatAppearance.BorderSize = 0;
            this.btnEntertain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntertain.Location = new System.Drawing.Point(94, 546);
            this.btnEntertain.Name = "btnEntertain";
            this.btnEntertain.Size = new System.Drawing.Size(174, 163);
            this.btnEntertain.TabIndex = 6;
            this.btnEntertain.UseVisualStyleBackColor = true;
            this.btnEntertain.Click += new System.EventHandler(this.btnEntertain_Click);
            // 
            // LobbyBTN
            // 
            this.LobbyBTN.BackColor = System.Drawing.Color.Transparent;
            this.LobbyBTN.BackgroundImage = global::Moonbase.Properties.Resources.LOBBY_icon;
            this.LobbyBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LobbyBTN.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.LobbyBTN.FlatAppearance.BorderSize = 0;
            this.LobbyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LobbyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LobbyBTN.ForeColor = System.Drawing.Color.Transparent;
            this.LobbyBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LobbyBTN.Location = new System.Drawing.Point(277, 633);
            this.LobbyBTN.Margin = new System.Windows.Forms.Padding(6);
            this.LobbyBTN.Name = "LobbyBTN";
            this.LobbyBTN.Size = new System.Drawing.Size(218, 196);
            this.LobbyBTN.TabIndex = 4;
            this.LobbyBTN.UseVisualStyleBackColor = false;
            this.LobbyBTN.Click += new System.EventHandler(this.LobbyBTN_Click);
            // 
            // commandCenterBTN
            // 
            this.commandCenterBTN.BackColor = System.Drawing.Color.Transparent;
            this.commandCenterBTN.BackgroundImage = global::Moonbase.Properties.Resources.COMMAND_ICON;
            this.commandCenterBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.commandCenterBTN.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.commandCenterBTN.FlatAppearance.BorderSize = 0;
            this.commandCenterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commandCenterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandCenterBTN.ForeColor = System.Drawing.Color.Transparent;
            this.commandCenterBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.commandCenterBTN.Location = new System.Drawing.Point(302, 42);
            this.commandCenterBTN.Margin = new System.Windows.Forms.Padding(6);
            this.commandCenterBTN.Name = "commandCenterBTN";
            this.commandCenterBTN.Size = new System.Drawing.Size(174, 146);
            this.commandCenterBTN.TabIndex = 0;
            this.commandCenterBTN.UseVisualStyleBackColor = false;
            this.commandCenterBTN.Click += new System.EventHandler(this.commandCenterBTN_Click);
            // 
            // labBTN
            // 
            this.labBTN.BackColor = System.Drawing.Color.Transparent;
            this.labBTN.BackgroundImage = global::Moonbase.Properties.Resources.Lab_ICON;
            this.labBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.labBTN.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.labBTN.FlatAppearance.BorderSize = 0;
            this.labBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBTN.ForeColor = System.Drawing.Color.Transparent;
            this.labBTN.Location = new System.Drawing.Point(0, 324);
            this.labBTN.Margin = new System.Windows.Forms.Padding(6);
            this.labBTN.Name = "labBTN";
            this.labBTN.Size = new System.Drawing.Size(174, 148);
            this.labBTN.TabIndex = 1;
            this.labBTN.UseVisualStyleBackColor = false;
            this.labBTN.Click += new System.EventHandler(this.labBTN_Click);
            // 
            // btnHallway
            // 
            this.btnHallway.BackgroundImage = global::Moonbase.Properties.Resources.corridor;
            this.btnHallway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHallway.FlatAppearance.BorderSize = 0;
            this.btnHallway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHallway.Location = new System.Drawing.Point(211, 239);
            this.btnHallway.Name = "btnHallway";
            this.btnHallway.Size = new System.Drawing.Size(345, 329);
            this.btnHallway.TabIndex = 5;
            this.btnHallway.UseVisualStyleBackColor = true;
            this.btnHallway.Click += new System.EventHandler(this.btnHallway_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.userLBL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current User";
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLBL.Location = new System.Drawing.Point(230, 63);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(176, 51);
            this.userLBL.TabIndex = 0;
            this.userLBL.Text = "(USER)";
            this.userLBL.Click += new System.EventHandler(this.userLBL_Click);
            // 
            // btnTicTacToe
            // 
            this.btnTicTacToe.BackColor = System.Drawing.Color.Transparent;
            this.btnTicTacToe.BackgroundImage = global::Moonbase.Properties.Resources.ticTacToe_icon;
            this.btnTicTacToe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTicTacToe.FlatAppearance.BorderSize = 0;
            this.btnTicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicTacToe.Location = new System.Drawing.Point(22, 158);
            this.btnTicTacToe.Name = "btnTicTacToe";
            this.btnTicTacToe.Size = new System.Drawing.Size(274, 223);
            this.btnTicTacToe.TabIndex = 3;
            this.btnTicTacToe.UseVisualStyleBackColor = false;
            this.btnTicTacToe.Visible = false;
            this.btnTicTacToe.Click += new System.EventHandler(this.btnTicTacToe_Click);
            // 
            // btnNumberGuess
            // 
            this.btnNumberGuess.BackColor = System.Drawing.Color.Transparent;
            this.btnNumberGuess.BackgroundImage = global::Moonbase.Properties.Resources.nguessing;
            this.btnNumberGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNumberGuess.FlatAppearance.BorderSize = 0;
            this.btnNumberGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberGuess.Location = new System.Drawing.Point(302, 158);
            this.btnNumberGuess.Name = "btnNumberGuess";
            this.btnNumberGuess.Size = new System.Drawing.Size(274, 223);
            this.btnNumberGuess.TabIndex = 4;
            this.btnNumberGuess.UseVisualStyleBackColor = false;
            this.btnNumberGuess.Visible = false;
            this.btnNumberGuess.Click += new System.EventHandler(this.btnNumberGuess_Click);
            // 
            // btnLocationLog
            // 
            this.btnLocationLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocationLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLocationLog.BackgroundImage = global::Moonbase.Properties.Resources.log_icon;
            this.btnLocationLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocationLog.FlatAppearance.BorderSize = 0;
            this.btnLocationLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocationLog.Location = new System.Drawing.Point(1477, -2);
            this.btnLocationLog.Name = "btnLocationLog";
            this.btnLocationLog.Size = new System.Drawing.Size(127, 140);
            this.btnLocationLog.TabIndex = 5;
            this.btnLocationLog.UseVisualStyleBackColor = false;
            this.btnLocationLog.Click += new System.EventHandler(this.btnLocationLog_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Moonbase.Properties.Resources.lobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 1001);
            this.Controls.Add(this.btnLocationLog);
            this.Controls.Add(this.btnNumberGuess);
            this.Controls.Add(this.btnTicTacToe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GRBXLocationInfo);
            this.Controls.Add(this.personalNav);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUNA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRBXLocationInfo.ResumeLayout(false);
            this.GRBXLocationInfo.PerformLayout();
            this.personalNav.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRBXLocationInfo;
        private System.Windows.Forms.TextBox TBRoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLRoomDesc;
        private System.Windows.Forms.GroupBox personalNav;
        private System.Windows.Forms.Button medBayBTN;
        private System.Windows.Forms.Button livingQtBTN;
        private System.Windows.Forms.Button commandCenterBTN;
        private System.Windows.Forms.Button LobbyBTN;
        private System.Windows.Forms.TextBox TXBXRoomDesc;
        private System.Windows.Forms.Button labBTN;
        private System.Windows.Forms.Button btnEntertain;
        private System.Windows.Forms.Button btnHallway;
        private System.Windows.Forms.Button btnMovie;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label userLBL;
        private System.Windows.Forms.Button btnTicTacToe;
        private System.Windows.Forms.Button btnNumberGuess;
        private System.Windows.Forms.Button btnLocationLog;
    }
}
