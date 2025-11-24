namespace bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.nhap_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chuthuong = new System.Windows.Forms.RadioButton();
            this.chuhoa = new System.Windows.Forms.RadioButton();
            this.xoa = new System.Windows.Forms.Button();
            this.ketqua = new System.Windows.Forms.Button();
            this.hienthikq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nhap_text
            // 
            this.nhap_text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhap_text.Location = new System.Drawing.Point(229, 90);
            this.nhap_text.Name = "nhap_text";
            this.nhap_text.Size = new System.Drawing.Size(392, 35);
            this.nhap_text.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chuhoa);
            this.groupBox1.Controls.Add(this.chuthuong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn kiểu chữ";
            // 
            // chuthuong
            // 
            this.chuthuong.AutoSize = true;
            this.chuthuong.Checked = true;
            this.chuthuong.Location = new System.Drawing.Point(23, 35);
            this.chuthuong.Name = "chuthuong";
            this.chuthuong.Size = new System.Drawing.Size(152, 31);
            this.chuthuong.TabIndex = 0;
            this.chuthuong.TabStop = true;
            this.chuthuong.Text = "Chữ thường";
            this.chuthuong.UseVisualStyleBackColor = true;
            this.chuthuong.CheckedChanged += new System.EventHandler(this.chuthuong_CheckedChanged);
            // 
            // chuhoa
            // 
            this.chuhoa.AutoSize = true;
            this.chuhoa.Location = new System.Drawing.Point(23, 70);
            this.chuhoa.Name = "chuhoa";
            this.chuhoa.Size = new System.Drawing.Size(119, 31);
            this.chuhoa.TabIndex = 1;
            this.chuhoa.Text = "Chữ hoa";
            this.chuhoa.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoa.Location = new System.Drawing.Point(521, 200);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(100, 107);
            this.xoa.TabIndex = 3;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // ketqua
            // 
            this.ketqua.Location = new System.Drawing.Point(80, 319);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(119, 47);
            this.ketqua.TabIndex = 4;
            this.ketqua.Text = "Kết quả";
            this.ketqua.UseVisualStyleBackColor = true;
            this.ketqua.Click += new System.EventHandler(this.ketqua_Click);
            // 
            // hienthikq
            // 
            this.hienthikq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienthikq.Location = new System.Drawing.Point(205, 324);
            this.hienthikq.Name = "hienthikq";
            this.hienthikq.Size = new System.Drawing.Size(416, 35);
            this.hienthikq.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.hienthikq);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nhap_text);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "đổi kiểu chữ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ClientSizeChanged += new System.EventHandler(this.f);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nhap_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chuhoa;
        private System.Windows.Forms.RadioButton chuthuong;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button ketqua;
        private System.Windows.Forms.TextBox hienthikq;
    }
}

