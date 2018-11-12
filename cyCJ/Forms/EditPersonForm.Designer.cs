namespace cyCJ.Forms
{
    partial class EditPersonForm
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
            this.okBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.remarkTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okBt
            // 
            this.okBt.Location = new System.Drawing.Point(66, 355);
            this.okBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(112, 34);
            this.okBt.TabIndex = 0;
            this.okBt.Text = "确定";
            this.okBt.UseVisualStyleBackColor = true;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(302, 355);
            this.cancelBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(112, 34);
            this.cancelBt.TabIndex = 1;
            this.cancelBt.Text = "取消";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(18, 27);
            this.nameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(148, 28);
            this.nameTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "备注：";
            // 
            // remarkTb
            // 
            this.remarkTb.Location = new System.Drawing.Point(18, 92);
            this.remarkTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remarkTb.Multiline = true;
            this.remarkTb.Name = "remarkTb";
            this.remarkTb.Size = new System.Drawing.Size(488, 222);
            this.remarkTb.TabIndex = 3;
            // 
            // EditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remarkTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.okBt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditPersonForm";
            this.Text = "EditPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox remarkTb;
    }
}