namespace RLMapLoader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapPackageManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteParkPBackupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreOriginalParkPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDefaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescanModsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapButton = new System.Windows.Forms.Button();
            this.rlDirTextBox = new System.Windows.Forms.TextBox();
            this.mapSelectComboBox = new System.Windows.Forms.ComboBox();
            this.modsDirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectRLButton = new System.Windows.Forms.Button();
            this.selectModsButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.loadOnStartCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagePreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.restoreDefaultMapCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mapTypeComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Freeplay Map:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.rescanModsFolderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapPackageManagerToolStripMenuItem,
            this.deleteParkPBackupToolStripMenuItem1,
            this.restoreOriginalParkPToolStripMenuItem,
            this.restoreDefaultSettingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // mapPackageManagerToolStripMenuItem
            // 
            this.mapPackageManagerToolStripMenuItem.Name = "mapPackageManagerToolStripMenuItem";
            this.mapPackageManagerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.mapPackageManagerToolStripMenuItem.Text = "Map Package Manager";
            this.mapPackageManagerToolStripMenuItem.Click += new System.EventHandler(this.mapPackageManagerToolStripMenuItem_Click);
            // 
            // deleteParkPBackupToolStripMenuItem1
            // 
            this.deleteParkPBackupToolStripMenuItem1.Name = "deleteParkPBackupToolStripMenuItem1";
            this.deleteParkPBackupToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.deleteParkPBackupToolStripMenuItem1.Text = "Delete Park_P Backup";
            this.deleteParkPBackupToolStripMenuItem1.Click += new System.EventHandler(this.deleteParkPBackupToolStripMenuItem_Click);
            // 
            // restoreOriginalParkPToolStripMenuItem
            // 
            this.restoreOriginalParkPToolStripMenuItem.Name = "restoreOriginalParkPToolStripMenuItem";
            this.restoreOriginalParkPToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.restoreOriginalParkPToolStripMenuItem.Text = "Restore Original Park_P";
            this.restoreOriginalParkPToolStripMenuItem.Click += new System.EventHandler(this.restoreOriginalParkPToolStripMenuItem_Click);
            // 
            // restoreDefaultSettingsToolStripMenuItem
            // 
            this.restoreDefaultSettingsToolStripMenuItem.Name = "restoreDefaultSettingsToolStripMenuItem";
            this.restoreDefaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.restoreDefaultSettingsToolStripMenuItem.Text = "Restore Default Settings";
            this.restoreDefaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.restoreDefaultSettingsToolStripMenuItem_Click);
            // 
            // rescanModsFolderToolStripMenuItem
            // 
            this.rescanModsFolderToolStripMenuItem.Name = "rescanModsFolderToolStripMenuItem";
            this.rescanModsFolderToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.rescanModsFolderToolStripMenuItem.Text = "Rescan Mods Folder";
            this.rescanModsFolderToolStripMenuItem.Click += new System.EventHandler(this.rescanModsFolderToolStripMenuItem_Click);
            // 
            // loadMapButton
            // 
            this.loadMapButton.Location = new System.Drawing.Point(340, 49);
            this.loadMapButton.Name = "loadMapButton";
            this.loadMapButton.Size = new System.Drawing.Size(47, 25);
            this.loadMapButton.TabIndex = 6;
            this.loadMapButton.Text = "Load";
            this.loadMapButton.UseVisualStyleBackColor = true;
            this.loadMapButton.Click += new System.EventHandler(this.loadMapButton_Click);
            // 
            // rlDirTextBox
            // 
            this.rlDirTextBox.Location = new System.Drawing.Point(75, 99);
            this.rlDirTextBox.Name = "rlDirTextBox";
            this.rlDirTextBox.Size = new System.Drawing.Size(258, 20);
            this.rlDirTextBox.TabIndex = 10;
            // 
            // mapSelectComboBox
            // 
            this.mapSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapSelectComboBox.FormattingEnabled = true;
            this.mapSelectComboBox.Location = new System.Drawing.Point(137, 52);
            this.mapSelectComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.mapSelectComboBox.Name = "mapSelectComboBox";
            this.mapSelectComboBox.Size = new System.Drawing.Size(198, 21);
            this.mapSelectComboBox.TabIndex = 11;
            this.mapSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.mapSelectComboBox_SelectedIndexChanged);
            // 
            // modsDirTextBox
            // 
            this.modsDirTextBox.Location = new System.Drawing.Point(75, 121);
            this.modsDirTextBox.Name = "modsDirTextBox";
            this.modsDirTextBox.Size = new System.Drawing.Size(258, 20);
            this.modsDirTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "RL Dir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mods Dir:";
            // 
            // selectRLButton
            // 
            this.selectRLButton.Location = new System.Drawing.Point(340, 96);
            this.selectRLButton.Name = "selectRLButton";
            this.selectRLButton.Size = new System.Drawing.Size(47, 23);
            this.selectRLButton.TabIndex = 15;
            this.selectRLButton.Text = "...";
            this.selectRLButton.UseVisualStyleBackColor = true;
            this.selectRLButton.Click += new System.EventHandler(this.selectRLButton_Click);
            // 
            // selectModsButton
            // 
            this.selectModsButton.Location = new System.Drawing.Point(340, 119);
            this.selectModsButton.Name = "selectModsButton";
            this.selectModsButton.Size = new System.Drawing.Size(47, 22);
            this.selectModsButton.TabIndex = 16;
            this.selectModsButton.Text = "...";
            this.selectModsButton.UseVisualStyleBackColor = true;
            this.selectModsButton.Click += new System.EventHandler(this.selectModsButton_Click);
            // 
            // loadOnStartCheckBox
            // 
            this.loadOnStartCheckBox.AutoSize = true;
            this.loadOnStartCheckBox.Location = new System.Drawing.Point(273, 77);
            this.loadOnStartCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.loadOnStartCheckBox.Name = "loadOnStartCheckBox";
            this.loadOnStartCheckBox.Size = new System.Drawing.Size(114, 17);
            this.loadOnStartCheckBox.TabIndex = 17;
            this.loadOnStartCheckBox.Text = "Load Map on Start";
            this.loadOnStartCheckBox.UseVisualStyleBackColor = true;
            this.loadOnStartCheckBox.CheckedChanged += new System.EventHandler(this.loadOnStartCheckBox_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 163);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // imagePreviewPictureBox
            // 
            this.imagePreviewPictureBox.Location = new System.Drawing.Point(11, 16);
            this.imagePreviewPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.imagePreviewPictureBox.Name = "imagePreviewPictureBox";
            this.imagePreviewPictureBox.Size = new System.Drawing.Size(339, 115);
            this.imagePreviewPictureBox.TabIndex = 19;
            this.imagePreviewPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imagePreviewPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 287);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(361, 145);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map Preview:";
            // 
            // restoreDefaultMapCheckBox
            // 
            this.restoreDefaultMapCheckBox.AutoSize = true;
            this.restoreDefaultMapCheckBox.Location = new System.Drawing.Point(137, 77);
            this.restoreDefaultMapCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.restoreDefaultMapCheckBox.Name = "restoreDefaultMapCheckBox";
            this.restoreDefaultMapCheckBox.Size = new System.Drawing.Size(135, 17);
            this.restoreDefaultMapCheckBox.TabIndex = 21;
            this.restoreDefaultMapCheckBox.Text = "Restore Park_P on exit";
            this.restoreDefaultMapCheckBox.UseVisualStyleBackColor = true;
            this.restoreDefaultMapCheckBox.CheckedChanged += new System.EventHandler(this.restoreDefaultMapCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Map Type:";
            // 
            // mapTypeComboBox
            // 
            this.mapTypeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.mapTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapTypeComboBox.FormattingEnabled = true;
            this.mapTypeComboBox.Items.AddRange(new object[] {
            "Defaults",
            "Custom"});
            this.mapTypeComboBox.Location = new System.Drawing.Point(137, 28);
            this.mapTypeComboBox.Name = "mapTypeComboBox";
            this.mapTypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mapTypeComboBox.Size = new System.Drawing.Size(198, 21);
            this.mapTypeComboBox.TabIndex = 23;
            this.mapTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.mapTypeComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 185);
            this.Controls.Add(this.mapTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.restoreDefaultMapCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.loadOnStartCheckBox);
            this.Controls.Add(this.selectModsButton);
            this.Controls.Add(this.selectRLButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modsDirTextBox);
            this.Controls.Add(this.mapSelectComboBox);
            this.Controls.Add(this.rlDirTextBox);
            this.Controls.Add(this.loadMapButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RL Map Loader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button loadMapButton;
        private System.Windows.Forms.TextBox rlDirTextBox;
        private System.Windows.Forms.ComboBox mapSelectComboBox;
        private System.Windows.Forms.TextBox modsDirTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectRLButton;
        private System.Windows.Forms.Button selectModsButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox loadOnStartCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.PictureBox imagePreviewPictureBox;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapPackageManagerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem deleteParkPBackupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restoreOriginalParkPToolStripMenuItem;
        private System.Windows.Forms.CheckBox restoreDefaultMapCheckBox;
        private System.Windows.Forms.ToolStripMenuItem restoreDefaultSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescanModsFolderToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mapTypeComboBox;
    }
}

