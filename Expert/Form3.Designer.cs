namespace Expert
{
    partial class Form3
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
            this.pan_cycle_info = new System.Windows.Forms.Panel();
            this.radioMechanizm = new System.Windows.Forms.RadioButton();
            this.radioSensor = new System.Windows.Forms.RadioButton();
            this.labelCycleType = new System.Windows.Forms.Label();
            this.labelNewCycleName = new System.Windows.Forms.Label();
            this.editNewCycleName = new System.Windows.Forms.TextBox();
            this.confirmDialogCycleInfoBtn = new System.Windows.Forms.PictureBox();
            this.closeDialogCycleInfoBtn = new System.Windows.Forms.PictureBox();
            this.pan_cycle_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmDialogCycleInfoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeDialogCycleInfoBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_cycle_info
            // 
            this.pan_cycle_info.BackColor = System.Drawing.Color.Beige;
            this.pan_cycle_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_cycle_info.Controls.Add(this.radioMechanizm);
            this.pan_cycle_info.Controls.Add(this.radioSensor);
            this.pan_cycle_info.Controls.Add(this.labelCycleType);
            this.pan_cycle_info.Controls.Add(this.labelNewCycleName);
            this.pan_cycle_info.Controls.Add(this.editNewCycleName);
            this.pan_cycle_info.Controls.Add(this.confirmDialogCycleInfoBtn);
            this.pan_cycle_info.Controls.Add(this.closeDialogCycleInfoBtn);
            this.pan_cycle_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_cycle_info.Location = new System.Drawing.Point(0, 0);
            this.pan_cycle_info.Name = "pan_cycle_info";
            this.pan_cycle_info.Size = new System.Drawing.Size(390, 211);
            this.pan_cycle_info.TabIndex = 0;
            this.pan_cycle_info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_cycle_info_MouseDown);
            // 
            // radioMechanizm
            // 
            this.radioMechanizm.AutoSize = true;
            this.radioMechanizm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioMechanizm.Location = new System.Drawing.Point(175, 91);
            this.radioMechanizm.Name = "radioMechanizm";
            this.radioMechanizm.Size = new System.Drawing.Size(103, 24);
            this.radioMechanizm.TabIndex = 3;
            this.radioMechanizm.Text = "Mechanizm";
            this.radioMechanizm.UseVisualStyleBackColor = true;
            // 
            // radioSensor
            // 
            this.radioSensor.AutoSize = true;
            this.radioSensor.Checked = true;
            this.radioSensor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioSensor.Location = new System.Drawing.Point(98, 91);
            this.radioSensor.Name = "radioSensor";
            this.radioSensor.Size = new System.Drawing.Size(71, 24);
            this.radioSensor.TabIndex = 2;
            this.radioSensor.TabStop = true;
            this.radioSensor.Text = "Sensor";
            this.radioSensor.UseVisualStyleBackColor = true;
            this.radioSensor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelCycleType
            // 
            this.labelCycleType.AutoSize = true;
            this.labelCycleType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCycleType.Location = new System.Drawing.Point(32, 91);
            this.labelCycleType.Name = "labelCycleType";
            this.labelCycleType.Size = new System.Drawing.Size(41, 20);
            this.labelCycleType.TabIndex = 0;
            this.labelCycleType.Text = "Type";
            // 
            // labelNewCycleName
            // 
            this.labelNewCycleName.AutoSize = true;
            this.labelNewCycleName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewCycleName.Location = new System.Drawing.Point(32, 29);
            this.labelNewCycleName.Name = "labelNewCycleName";
            this.labelNewCycleName.Size = new System.Drawing.Size(58, 40);
            this.labelNewCycleName.TabIndex = 0;
            this.labelNewCycleName.Text = "Device \r\nname";
            // 
            // editNewCycleName
            // 
            this.editNewCycleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editNewCycleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editNewCycleName.Location = new System.Drawing.Point(98, 35);
            this.editNewCycleName.MaxLength = 25;
            this.editNewCycleName.Name = "editNewCycleName";
            this.editNewCycleName.Size = new System.Drawing.Size(239, 29);
            this.editNewCycleName.TabIndex = 1;
            this.editNewCycleName.TabStop = false;
            this.editNewCycleName.Text = "test";
            // 
            // confirmDialogCycleInfoBtn
            // 
            this.confirmDialogCycleInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmDialogCycleInfoBtn.Image = global::Expert.Properties.Resources.checkmark_verification_circular_button_outline;
            this.confirmDialogCycleInfoBtn.Location = new System.Drawing.Point(142, 148);
            this.confirmDialogCycleInfoBtn.Name = "confirmDialogCycleInfoBtn";
            this.confirmDialogCycleInfoBtn.Size = new System.Drawing.Size(50, 50);
            this.confirmDialogCycleInfoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.confirmDialogCycleInfoBtn.TabIndex = 0;
            this.confirmDialogCycleInfoBtn.TabStop = false;
            this.confirmDialogCycleInfoBtn.Click += new System.EventHandler(this.confirmDialogCycleInfoBtn_Click);
            this.confirmDialogCycleInfoBtn.MouseLeave += new System.EventHandler(this.confirmDialogCycleInfoBtn_MouseLeave);
            this.confirmDialogCycleInfoBtn.MouseHover += new System.EventHandler(this.confirmDialogCycleInfoBtn_MouseHover);
            // 
            // closeDialogCycleInfoBtn
            // 
            this.closeDialogCycleInfoBtn.Image = global::Expert.Properties.Resources.croos_circular_outlined_button_symbol;
            this.closeDialogCycleInfoBtn.Location = new System.Drawing.Point(251, 171);
            this.closeDialogCycleInfoBtn.Name = "closeDialogCycleInfoBtn";
            this.closeDialogCycleInfoBtn.Size = new System.Drawing.Size(27, 27);
            this.closeDialogCycleInfoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeDialogCycleInfoBtn.TabIndex = 0;
            this.closeDialogCycleInfoBtn.TabStop = false;
            this.closeDialogCycleInfoBtn.Click += new System.EventHandler(this.closeDialogCycleInfoBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 211);
            this.Controls.Add(this.pan_cycle_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form3";
            this.Text = "cycleInfoForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.pan_cycle_info.ResumeLayout(false);
            this.pan_cycle_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmDialogCycleInfoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeDialogCycleInfoBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_cycle_info;
        private System.Windows.Forms.RadioButton radioMechanizm;
        private System.Windows.Forms.RadioButton radioSensor;
        private System.Windows.Forms.Label labelCycleType;
        private System.Windows.Forms.Label labelNewCycleName;
        private System.Windows.Forms.TextBox editNewCycleName;
        private System.Windows.Forms.PictureBox confirmDialogCycleInfoBtn;
        private System.Windows.Forms.PictureBox closeDialogCycleInfoBtn;
    }
}