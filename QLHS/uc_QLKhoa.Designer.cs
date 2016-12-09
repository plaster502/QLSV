namespace QLHS
{
    partial class uc_QLKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_QLKhoa));
            this.pn_Nav = new System.Windows.Forms.Panel();
            this.dgv_DsKhoa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pn_Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Nav
            // 
            this.pn_Nav.Controls.Add(this.textBox2);
            this.pn_Nav.Controls.Add(this.label2);
            this.pn_Nav.Controls.Add(this.simpleButton1);
            this.pn_Nav.Controls.Add(this.textBox1);
            this.pn_Nav.Controls.Add(this.label1);
            this.pn_Nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Nav.Location = new System.Drawing.Point(0, 0);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(216, 327);
            this.pn_Nav.TabIndex = 0;
            // 
            // dgv_DsKhoa
            // 
            this.dgv_DsKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DsKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DsKhoa.Location = new System.Drawing.Point(216, 0);
            this.dgv_DsKhoa.Name = "dgv_DsKhoa";
            this.dgv_DsKhoa.Size = new System.Drawing.Size(474, 327);
            this.dgv_DsKhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(3, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(101, 125);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 36);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Cập nhật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khoa";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(3, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 26);
            this.textBox2.TabIndex = 4;
            // 
            // uc_QLKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DsKhoa);
            this.Controls.Add(this.pn_Nav);
            this.Name = "uc_QLKhoa";
            this.Size = new System.Drawing.Size(690, 327);
            this.pn_Nav.ResumeLayout(false);
            this.pn_Nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DsKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Nav;
        private System.Windows.Forms.DataGridView dgv_DsKhoa;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
