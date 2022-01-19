
namespace DataSynchronizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SynchronizeButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AdvancedOptions_CB = new System.Windows.Forms.CheckBox();
            this.AdvancedOptions_Box = new System.Windows.Forms.GroupBox();
            this.CSD = new System.Windows.Forms.Button();
            this.SetOriginLocation = new System.Windows.Forms.Button();
            this.OriginLocationText = new System.Windows.Forms.TextBox();
            this.SetTargetLocation = new System.Windows.Forms.Button();
            this.TargetLocationText = new System.Windows.Forms.TextBox();
            this.TargetChange = new System.Windows.Forms.FolderBrowserDialog();
            this.OriginChange = new System.Windows.Forms.FolderBrowserDialog();
            this.DateImport = new System.Windows.Forms.OpenFileDialog();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.DialogTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.AdvancedOptions_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // SynchronizeButton
            // 
            this.SynchronizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SynchronizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SynchronizeButton.Location = new System.Drawing.Point(165, 116);
            this.SynchronizeButton.Name = "SynchronizeButton";
            this.SynchronizeButton.Size = new System.Drawing.Size(270, 125);
            this.SynchronizeButton.TabIndex = 0;
            this.SynchronizeButton.Text = "Synchronize";
            this.SynchronizeButton.UseVisualStyleBackColor = true;
            this.SynchronizeButton.Click += new System.EventHandler(this.SynchronizeButton_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(520, 390);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(50, 50);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // AdvancedOptions_CB
            // 
            this.AdvancedOptions_CB.AutoSize = true;
            this.AdvancedOptions_CB.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdvancedOptions_CB.Location = new System.Drawing.Point(448, 424);
            this.AdvancedOptions_CB.Name = "AdvancedOptions_CB";
            this.AdvancedOptions_CB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AdvancedOptions_CB.Size = new System.Drawing.Size(66, 17);
            this.AdvancedOptions_CB.TabIndex = 4;
            this.AdvancedOptions_CB.Text = "Advanced";
            this.AdvancedOptions_CB.UseVisualStyleBackColor = true;
            this.AdvancedOptions_CB.CheckedChanged += new System.EventHandler(this.AdvancedOptions_CB_CheckedChanged);
            // 
            // AdvancedOptions_Box
            // 
            this.AdvancedOptions_Box.Controls.Add(this.CSD);
            this.AdvancedOptions_Box.Controls.Add(this.SetOriginLocation);
            this.AdvancedOptions_Box.Controls.Add(this.OriginLocationText);
            this.AdvancedOptions_Box.Controls.Add(this.SetTargetLocation);
            this.AdvancedOptions_Box.Controls.Add(this.TargetLocationText);
            this.AdvancedOptions_Box.Location = new System.Drawing.Point(165, 247);
            this.AdvancedOptions_Box.Name = "AdvancedOptions_Box";
            this.AdvancedOptions_Box.Size = new System.Drawing.Size(270, 175);
            this.AdvancedOptions_Box.TabIndex = 5;
            this.AdvancedOptions_Box.TabStop = false;
            this.AdvancedOptions_Box.Text = "Advanced";
            this.AdvancedOptions_Box.Visible = false;
            // 
            // CSD
            // 
            this.CSD.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CSD.Location = new System.Drawing.Point(6, 149);
            this.CSD.Name = "CSD";
            this.CSD.Size = new System.Drawing.Size(101, 20);
            this.CSD.TabIndex = 10;
            this.CSD.Text = "ClearSavedDates";
            this.CSD.UseVisualStyleBackColor = true;
            this.CSD.Click += new System.EventHandler(this.CSD_Click);
            // 
            // SetOriginLocation
            // 
            this.SetOriginLocation.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetOriginLocation.Location = new System.Drawing.Point(6, 26);
            this.SetOriginLocation.Name = "SetOriginLocation";
            this.SetOriginLocation.Size = new System.Drawing.Size(101, 20);
            this.SetOriginLocation.TabIndex = 9;
            this.SetOriginLocation.Text = "Set OriginLocation";
            this.SetOriginLocation.UseVisualStyleBackColor = true;
            this.SetOriginLocation.Click += new System.EventHandler(this.SetOriginLocation_Click);
            // 
            // OriginLocationText
            // 
            this.OriginLocationText.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OriginLocationText.Location = new System.Drawing.Point(6, 52);
            this.OriginLocationText.Name = "OriginLocationText";
            this.OriginLocationText.ReadOnly = true;
            this.OriginLocationText.Size = new System.Drawing.Size(258, 21);
            this.OriginLocationText.TabIndex = 8;
            // 
            // SetTargetLocation
            // 
            this.SetTargetLocation.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetTargetLocation.Location = new System.Drawing.Point(6, 88);
            this.SetTargetLocation.Name = "SetTargetLocation";
            this.SetTargetLocation.Size = new System.Drawing.Size(101, 20);
            this.SetTargetLocation.TabIndex = 7;
            this.SetTargetLocation.Text = "Set TargetLocation";
            this.SetTargetLocation.UseVisualStyleBackColor = true;
            this.SetTargetLocation.Click += new System.EventHandler(this.SetTargetLocation_Click);
            // 
            // TargetLocationText
            // 
            this.TargetLocationText.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TargetLocationText.Location = new System.Drawing.Point(6, 114);
            this.TargetLocationText.Name = "TargetLocationText";
            this.TargetLocationText.ReadOnly = true;
            this.TargetLocationText.Size = new System.Drawing.Size(258, 21);
            this.TargetLocationText.TabIndex = 6;
            // 
            // DateImport
            // 
            this.DateImport.DefaultExt = "txt";
            this.DateImport.FileName = "Dates";
            this.DateImport.Filter = "Text-Files (*.txt)|*.txt*";
            this.DateImport.FilterIndex = 0;
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(165, 59);
            this.PB.Maximum = 10000;
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(270, 29);
            this.PB.TabIndex = 6;
            // 
            // DialogTimer
            // 
            this.DialogTimer.Interval = 20;
            this.DialogTimer.Tick += new System.EventHandler(this.DialogTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.AdvancedOptions_Box);
            this.Controls.Add(this.AdvancedOptions_CB);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.SynchronizeButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataSynchronizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.AdvancedOptions_Box.ResumeLayout(false);
            this.AdvancedOptions_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SynchronizeButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.CheckBox AdvancedOptions_CB;
        private System.Windows.Forms.GroupBox AdvancedOptions_Box;
        private System.Windows.Forms.Button CSD;
        private System.Windows.Forms.Button SetOriginLocation;
        private System.Windows.Forms.TextBox OriginLocationText;
        private System.Windows.Forms.Button SetTargetLocation;
        private System.Windows.Forms.TextBox TargetLocationText;
        private System.Windows.Forms.FolderBrowserDialog TargetChange;
        private System.Windows.Forms.FolderBrowserDialog OriginChange;
        private System.Windows.Forms.OpenFileDialog DateImport;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.Timer DialogTimer;
    }
}

