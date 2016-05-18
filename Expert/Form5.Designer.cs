namespace Expert
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditExpertName = new System.Windows.Forms.TextBox();
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
            this.pan_cycle_info.Controls.Add(this.label2);
            this.pan_cycle_info.Controls.Add(this.label1);
            this.pan_cycle_info.Controls.Add(this.EditExpertName);
            this.pan_cycle_info.Controls.Add(this.confirmDialogCycleInfoBtn);
            this.pan_cycle_info.Controls.Add(this.closeDialogCycleInfoBtn);
            this.pan_cycle_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_cycle_info.Location = new System.Drawing.Point(0, 0);
            this.pan_cycle_info.Name = "pan_cycle_info";
            this.pan_cycle_info.Size = new System.Drawing.Size(390, 211);
            this.pan_cycle_info.TabIndex = 0;
            this.pan_cycle_info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_cycle_info_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавление эксперта";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия Имя";
            // 
            // EditExpertName
            // 
            this.EditExpertName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditExpertName.Location = new System.Drawing.Point(54, 88);
            this.EditExpertName.Name = "EditExpertName";
            this.EditExpertName.Size = new System.Drawing.Size(239, 29);
            this.EditExpertName.TabIndex = 1;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 211);
            this.Controls.Add(this.pan_cycle_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form5";
            this.Text = "cycleInfoForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            this.pan_cycle_info.ResumeLayout(false);
            this.pan_cycle_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmDialogCycleInfoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeDialogCycleInfoBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_cycle_info;
        private System.Windows.Forms.PictureBox confirmDialogCycleInfoBtn;
        private System.Windows.Forms.PictureBox closeDialogCycleInfoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditExpertName;
    }
}