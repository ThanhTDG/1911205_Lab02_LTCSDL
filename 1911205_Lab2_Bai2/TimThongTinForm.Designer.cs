
namespace _1911205_Lab2_Bai2
{
    partial class TimThongTinForm
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
            this.grFind = new System.Windows.Forms.GroupBox();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdSdt = new System.Windows.Forms.RadioButton();
            this.lbText = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.grFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // grFind
            // 
            this.grFind.Controls.Add(this.rdSdt);
            this.grFind.Controls.Add(this.rdTen);
            this.grFind.Controls.Add(this.rdMa);
            this.grFind.Location = new System.Drawing.Point(33, 25);
            this.grFind.Name = "grFind";
            this.grFind.Size = new System.Drawing.Size(345, 65);
            this.grFind.TabIndex = 0;
            this.grFind.TabStop = false;
            this.grFind.Text = "Tìm theo";
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Location = new System.Drawing.Point(7, 20);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(58, 17);
            this.rdMa.TabIndex = 0;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Mã GV";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(127, 19);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(57, 17);
            this.rdTen.TabIndex = 0;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Họ tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdSdt
            // 
            this.rdSdt.AutoSize = true;
            this.rdSdt.Location = new System.Drawing.Point(246, 19);
            this.rdSdt.Name = "rdSdt";
            this.rdSdt.Size = new System.Drawing.Size(88, 17);
            this.rdSdt.TabIndex = 0;
            this.rdSdt.TabStop = true;
            this.rdSdt.Text = "Số điện thoại";
            this.rdSdt.UseVisualStyleBackColor = true;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(40, 107);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(35, 13);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "label1";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(118, 99);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(178, 20);
            this.txtFind.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(303, 96);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // TimThongTinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 159);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.grFind);
            this.Name = "TimThongTinForm";
            this.Text = "TimThongTinForm";
            this.Load += new System.EventHandler(this.TimThongTinForm_Load);
            this.grFind.ResumeLayout(false);
            this.grFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grFind;
        private System.Windows.Forms.RadioButton rdSdt;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnOK;
    }
}