namespace TaoSoNgauNhien
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
            this.lblSoLan = new System.Windows.Forms.Label();
            this.txtSoNguoiDungNhap = new System.Windows.Forms.TextBox();
            this.btnTinhRanDom = new System.Windows.Forms.Button();
            this.txtDayNgauNhienAm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người dùng nhập";
            // 
            // lblSoLan
            // 
            this.lblSoLan.AutoSize = true;
            this.lblSoLan.Location = new System.Drawing.Point(223, 104);
            this.lblSoLan.Name = "lblSoLan";
            this.lblSoLan.Size = new System.Drawing.Size(37, 13);
            this.lblSoLan.TabIndex = 1;
            this.lblSoLan.Text = "Số lần";
            // 
            // txtSoNguoiDungNhap
            // 
            this.txtSoNguoiDungNhap.Location = new System.Drawing.Point(125, 24);
            this.txtSoNguoiDungNhap.Name = "txtSoNguoiDungNhap";
            this.txtSoNguoiDungNhap.Size = new System.Drawing.Size(100, 20);
            this.txtSoNguoiDungNhap.TabIndex = 2;
            // 
            // btnTinhRanDom
            // 
            this.btnTinhRanDom.Location = new System.Drawing.Point(125, 146);
            this.btnTinhRanDom.Name = "btnTinhRanDom";
            this.btnTinhRanDom.Size = new System.Drawing.Size(75, 23);
            this.btnTinhRanDom.TabIndex = 3;
            this.btnTinhRanDom.Text = "button1";
            this.btnTinhRanDom.UseVisualStyleBackColor = true;
            this.btnTinhRanDom.Click += new System.EventHandler(this.btnTinhRanDom_Click);
            // 
            // txtDayNgauNhienAm
            // 
            this.txtDayNgauNhienAm.Location = new System.Drawing.Point(125, 66);
            this.txtDayNgauNhienAm.Name = "txtDayNgauNhienAm";
            this.txtDayNgauNhienAm.Size = new System.Drawing.Size(100, 20);
            this.txtDayNgauNhienAm.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtDayNgauNhienAm);
            this.Controls.Add(this.btnTinhRanDom);
            this.Controls.Add(this.txtSoNguoiDungNhap);
            this.Controls.Add(this.lblSoLan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoLan;
        private System.Windows.Forms.TextBox txtSoNguoiDungNhap;
        private System.Windows.Forms.Button btnTinhRanDom;
        private System.Windows.Forms.TextBox txtDayNgauNhienAm;
    }
}

