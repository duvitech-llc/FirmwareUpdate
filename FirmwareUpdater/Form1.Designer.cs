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
            this.cbNextGen = new System.Windows.Forms.CheckBox();
            this.cbFirmwareSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProgram = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNextGen
            // 
            this.cbNextGen.AutoSize = true;
            this.cbNextGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNextGen.Location = new System.Drawing.Point(442, 61);
            this.cbNextGen.Name = "cbNextGen";
            this.cbNextGen.Size = new System.Drawing.Size(133, 17);
            this.cbNextGen.TabIndex = 0;
            this.cbNextGen.Text = "Next Gen Firmware";
            this.cbNextGen.UseVisualStyleBackColor = true;
            this.cbNextGen.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.btnProgram.Text = "Program";
            this.btnProgram.UseVisualStyleBackColor = true;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(27, 117);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 226);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFirmwareSelector);
            this.Controls.Add(this.cbNextGen);
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

        private System.Windows.Forms.CheckBox cbNextGen;
        private System.Windows.Forms.ComboBox cbFirmwareSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label2;
    }
}

