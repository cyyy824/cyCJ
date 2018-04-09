namespace cyCJ
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
            this.addimageBt = new System.Windows.Forms.Button();
            this.clearImageBt = new System.Windows.Forms.Button();
            this.imgPB = new System.Windows.Forms.PictureBox();
            this.remarkTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // okBt
            // 
            this.okBt.Location = new System.Drawing.Point(41, 289);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(75, 23);
            this.okBt.TabIndex = 0;
            this.okBt.Text = "确定";
            this.okBt.UseVisualStyleBackColor = true;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(190, 289);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(75, 23);
            this.cancelBt.TabIndex = 1;
            this.cancelBt.Text = "取消";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(12, 18);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 21);
            this.nameTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "备注：";
            // 
            // addimageBt
            // 
            this.addimageBt.Location = new System.Drawing.Point(50, 224);
            this.addimageBt.Name = "addimageBt";
            this.addimageBt.Size = new System.Drawing.Size(75, 42);
            this.addimageBt.TabIndex = 6;
            this.addimageBt.Text = "更换图片";
            this.addimageBt.UseVisualStyleBackColor = true;
            this.addimageBt.Click += new System.EventHandler(this.addimageBt_Click);
            // 
            // clearImageBt
            // 
            this.clearImageBt.Location = new System.Drawing.Point(249, 214);
            this.clearImageBt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearImageBt.Name = "clearImageBt";
            this.clearImageBt.Size = new System.Drawing.Size(61, 26);
            this.clearImageBt.TabIndex = 8;
            this.clearImageBt.Text = "清除图片";
            this.clearImageBt.UseVisualStyleBackColor = true;
            this.clearImageBt.Click += new System.EventHandler(this.clearImageBt_Click);
            // 
            // imgPB
            // 
            this.imgPB.Image = global::cyCJ.Resource.nopictype;
            this.imgPB.Location = new System.Drawing.Point(137, 214);
            this.imgPB.Margin = new System.Windows.Forms.Padding(2);
            this.imgPB.Name = "imgPB";
            this.imgPB.Size = new System.Drawing.Size(91, 67);
            this.imgPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPB.TabIndex = 7;
            this.imgPB.TabStop = false;
            this.imgPB.DoubleClick += new System.EventHandler(this.imgPB_DoubleClick);
            // 
            // remarkTb
            // 
            this.remarkTb.Location = new System.Drawing.Point(12, 61);
            this.remarkTb.Multiline = true;
            this.remarkTb.Name = "remarkTb";
            this.remarkTb.Size = new System.Drawing.Size(327, 149);
            this.remarkTb.TabIndex = 3;
            // 
            // EditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 324);
            this.Controls.Add(this.clearImageBt);
            this.Controls.Add(this.imgPB);
            this.Controls.Add(this.addimageBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remarkTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.okBt);
            this.Name = "EditPersonForm";
            this.Text = "EditPersonForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addimageBt;
        private System.Windows.Forms.PictureBox imgPB;
        private System.Windows.Forms.Button clearImageBt;
        private System.Windows.Forms.TextBox remarkTb;
    }
}