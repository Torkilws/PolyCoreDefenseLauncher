namespace PolyCoreDefenseLauncher
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.cmbVersions = new System.Windows.Forms.ComboBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonDeleteCache = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVersionLauncher = new System.Windows.Forms.Label();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVersions
            // 
            this.cmbVersions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVersions.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbVersions.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbVersions.Items.AddRange(new object[] {
            "v0.1.0",
            "v0.2.0",
            "v0.3.0"});
            this.cmbVersions.Location = new System.Drawing.Point(195, 12);
            this.cmbVersions.MaxDropDownItems = 10;
            this.cmbVersions.Name = "cmbVersions";
            this.cmbVersions.Size = new System.Drawing.Size(328, 32);
            this.cmbVersions.TabIndex = 0;
            this.cmbVersions.SelectedIndexChanged += new System.EventHandler(this.cmbVersions_SelectedIndexChanged);
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDownload.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDownload.Location = new System.Drawing.Point(195, 50);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(161, 66);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPlay.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.Location = new System.Drawing.Point(362, 50);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(161, 95);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(195, 179);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(159, 24);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Select game version";
            // 
            // buttonDeleteCache
            // 
            this.buttonDeleteCache.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteCache.Location = new System.Drawing.Point(30, 193);
            this.buttonDeleteCache.Name = "buttonDeleteCache";
            this.buttonDeleteCache.Size = new System.Drawing.Size(139, 24);
            this.buttonDeleteCache.TabIndex = 4;
            this.buttonDeleteCache.Text = "Delete All Cache";
            this.buttonDeleteCache.UseVisualStyleBackColor = true;
            this.buttonDeleteCache.Click += new System.EventHandler(this.buttonDeleteCache_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(195, 122);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(161, 23);
            this.progressBar.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PolyCoreDefenseLauncher.Properties.Resources.PolyCoreDefense_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelVersionLauncher
            // 
            this.labelVersionLauncher.AutoSize = true;
            this.labelVersionLauncher.BackColor = System.Drawing.Color.Transparent;
            this.labelVersionLauncher.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVersionLauncher.Location = new System.Drawing.Point(30, 131);
            this.labelVersionLauncher.Name = "labelVersionLauncher";
            this.labelVersionLauncher.Size = new System.Drawing.Size(139, 24);
            this.labelVersionLauncher.TabIndex = 7;
            this.labelVersionLauncher.Text = "Version Launcher";
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteSelected.Location = new System.Drawing.Point(30, 163);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(139, 24);
            this.buttonDeleteSelected.TabIndex = 8;
            this.buttonDeleteSelected.Text = "Delete Selected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 229);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.labelVersionLauncher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonDeleteCache);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.cmbVersions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "PolyCore Defense Version Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbVersions;
        private Button buttonDownload;
        private Button buttonPlay;
        private Label labelStatus;
        private Button buttonDeleteCache;
        private ProgressBar progressBar;
        private PictureBox pictureBox1;
        private Label labelVersionLauncher;
        private Button buttonDeleteSelected;
    }
}