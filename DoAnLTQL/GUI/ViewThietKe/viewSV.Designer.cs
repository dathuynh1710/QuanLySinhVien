using System;

namespace GUI
{
    partial class viewSV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxAnhSV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnhSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(63, 139);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(50, 18);
            this.lbMSSV.TabIndex = 1;
            this.lbMSSV.Text = "MSSV";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(63, 173);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(53, 18);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "HoTen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "MSSV:";
            // 
            // pictureBoxAnhSV
            // 
            this.pictureBoxAnhSV.Image = global::GUI.Properties.Resources.image;
            this.pictureBoxAnhSV.Location = new System.Drawing.Point(42, 3);
            this.pictureBoxAnhSV.Name = "pictureBoxAnhSV";
            this.pictureBoxAnhSV.Size = new System.Drawing.Size(113, 113);
            this.pictureBoxAnhSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAnhSV.TabIndex = 3;
            this.pictureBoxAnhSV.TabStop = false;
            // 
            // viewSV
            // 
            this.Click += new EventHandler(viewSV_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(208)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxAnhSV);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbMSSV);
            this.Name = "viewSV";
            this.Size = new System.Drawing.Size(199, 207);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnhSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.PictureBox pictureBoxAnhSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
