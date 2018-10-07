namespace FirmwareUpdater
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
            this.cbFirmwareSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProgram = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReboot = new System.Windows.Forms.Button();
            this.lblHudStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbFirmwareSelector
            // 
            this.cbFirmwareSelector.FormattingEnabled = true;
            this.cbFirmwareSelector.Location = new System.Drawing.Point(27, 59);
            this.cbFirmwareSelector.Name = "cbFirmwareSelector";
            this.cbFirmwareSelector.Size = new System.Drawing.Size(342, 21);
            this.cbFirmwareSelector.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Firmware to Load:";
            // 
            // btnProgram
            // 
            this.btnProgram.Location = new System.Drawing.Point(518, 168);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(88, 35);
            this.btnProgram.TabIndex = 3;
            this.btnProgram.Text = "Update HUD";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStatus.Location = new System.Drawing.Point(27, 117);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStatus.Size = new System.Drawing.Size(463, 86);
            this.tbStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status Window:";
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(518, 117);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(88, 35);
            this.btnReboot.TabIndex = 7;
            this.btnReboot.Text = "Bootloader";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // lblHudStatus
            // 
            this.lblHudStatus.AutoSize = true;
            this.lblHudStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHudStatus.ForeColor = System.Drawing.Color.Red;
            this.lblHudStatus.Location = new System.Drawing.Point(419, 23);
            this.lblHudStatus.Name = "lblHudStatus";
            this.lblHudStatus.Size = new System.Drawing.Size(187, 20);
            this.lblHudStatus.TabIndex = 8;
            this.lblHudStatus.Text = "HUD NOT DETECTED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 226);
            this.Controls.Add(this.lblHudStatus);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFirmwareSelector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "HUD Firmware Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbFirmwareSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Label lblHudStatus;
    }
}

