namespace bai8
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.giai = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inA = new System.Windows.Forms.TextBox();
            this.inB = new System.Windows.Forms.TextBox();
            this.outAB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT AX+B =0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nghiệm phương trình";
            // 
            // giai
            // 
            this.giai.Enabled = false;
            this.giai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giai.Location = new System.Drawing.Point(130, 298);
            this.giai.Name = "giai";
            this.giai.Size = new System.Drawing.Size(74, 40);
            this.giai.TabIndex = 4;
            this.giai.Text = "&Giải";
            this.giai.UseVisualStyleBackColor = true;
            this.giai.Click += new System.EventHandler(this.giai_Click);
            // 
            // Xoa
            // 
            this.Xoa.Enabled = false;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(265, 298);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(74, 40);
            this.Xoa.TabIndex = 5;
            this.Xoa.Text = "&xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(378, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inA
            // 
            this.inA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inA.Location = new System.Drawing.Point(239, 145);
            this.inA.Name = "inA";
            this.inA.Size = new System.Drawing.Size(201, 26);
            this.inA.TabIndex = 7;
            this.inA.TextChanged += new System.EventHandler(this.inA_TextChanged);
            // 
            // inB
            // 
            this.inB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inB.Location = new System.Drawing.Point(239, 189);
            this.inB.Name = "inB";
            this.inB.Size = new System.Drawing.Size(201, 26);
            this.inB.TabIndex = 8;
            this.inB.TextChanged += new System.EventHandler(this.inB_TextChanged);
            // 
            // outAB
            // 
            this.outAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outAB.Location = new System.Drawing.Point(239, 242);
            this.outAB.Name = "outAB";
            this.outAB.ReadOnly = true;
            this.outAB.Size = new System.Drawing.Size(201, 26);
            this.outAB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.outAB);
            this.Controls.Add(this.inB);
            this.Controls.Add(this.inA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.giai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "giải phương trình bậc nhất";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button giai;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inA;
        private System.Windows.Forms.TextBox inB;
        private System.Windows.Forms.TextBox outAB;
    }
}

