﻿
namespace Picturebox
{
    partial class FrmCB10
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.picXanh = new System.Windows.Forms.PictureBox();
            this.picDo = new System.Windows.Forms.PictureBox();
            this.picXam2 = new System.Windows.Forms.PictureBox();
            this.picXam1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picXanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXam1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 22);
            this.dateTimePicker1.TabIndex = 117;
            // 
            // picXanh
            // 
            this.picXanh.Image = global::Picturebox.Properties.Resources.xanh1;
            this.picXanh.Location = new System.Drawing.Point(117, 171);
            this.picXanh.Name = "picXanh";
            this.picXanh.Size = new System.Drawing.Size(91, 79);
            this.picXanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXanh.TabIndex = 116;
            this.picXanh.TabStop = false;
            this.picXanh.Visible = false;
            // 
            // picDo
            // 
            this.picDo.Image = global::Picturebox.Properties.Resources._do;
            this.picDo.Location = new System.Drawing.Point(320, 171);
            this.picDo.Name = "picDo";
            this.picDo.Size = new System.Drawing.Size(91, 79);
            this.picDo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDo.TabIndex = 115;
            this.picDo.TabStop = false;
            this.picDo.Visible = false;
            // 
            // picXam2
            // 
            this.picXam2.Image = global::Picturebox.Properties.Resources.komau1;
            this.picXam2.Location = new System.Drawing.Point(320, 171);
            this.picXam2.Name = "picXam2";
            this.picXam2.Size = new System.Drawing.Size(91, 79);
            this.picXam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXam2.TabIndex = 114;
            this.picXam2.TabStop = false;
            // 
            // picXam1
            // 
            this.picXam1.Image = global::Picturebox.Properties.Resources.komau1;
            this.picXam1.Location = new System.Drawing.Point(117, 171);
            this.picXam1.Name = "picXam1";
            this.picXam1.Size = new System.Drawing.Size(91, 79);
            this.picXam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXam1.TabIndex = 113;
            this.picXam1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "Cảnh báo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 111;
            this.label4.Text = "Hoạt động";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTime.Location = new System.Drawing.Point(122, 22);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(117, 22);
            this.dtpTime.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Trạng thái";
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(122, 90);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(86, 22);
            this.txtNhietDo.TabIndex = 108;
            this.txtNhietDo.TextChanged += new System.EventHandler(this.txtNhietDo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nhiệt độ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "Thời gian";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmCB10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.picXanh);
            this.Controls.Add(this.picDo);
            this.Controls.Add(this.picXam2);
            this.Controls.Add(this.picXam1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhietDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCB10";
            this.Text = "Cảm biến 10";
            ((System.ComponentModel.ISupportInitialize)(this.picXanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox picXanh;
        private System.Windows.Forms.PictureBox picDo;
        private System.Windows.Forms.PictureBox picXam2;
        private System.Windows.Forms.PictureBox picXam1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}