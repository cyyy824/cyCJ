namespace cyCJ
{
    partial class EditPrizeForm
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
            this.clearImageBt = new System.Windows.Forms.Button();
            this.addimageBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.cancelBt = new System.Windows.Forms.Button();
            this.okBt = new System.Windows.Forms.Button();
            this.imgPB = new System.Windows.Forms.PictureBox();
            this.numTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPB)).BeginInit();
            this.SuspendLayout();
            // 
            // clearImageBt
            // 
            this.clearImageBt.Location = new System.Drawing.Point(247, 70);
            this.clearImageBt.Margin = new System.Windows.Forms.Padding(2);
            this.clearImageBt.Name = "clearImageBt";
            this.clearImageBt.Size = new System.Drawing.Size(61, 26);
            this.clearImageBt.TabIndex = 17;
            this.clearImageBt.Text = "清除图片";
            this.clearImageBt.UseVisualStyleBackColor = true;
            this.clearImageBt.Click += new System.EventHandler(this.clearImageBt_Click);
            // 
            // addimageBt
            // 
            this.addimageBt.Location = new System.Drawing.Point(48, 80);
            this.addimageBt.Name = "addimageBt";
            this.addimageBt.Size = new System.Drawing.Size(75, 42);
            this.addimageBt.TabIndex = 15;
            this.addimageBt.Text = "更换图片";
            this.addimageBt.UseVisualStyleBackColor = true;
            this.addimageBt.Click += new System.EventHandler(this.addimageBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "抽取数量：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "奖项：";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(47, 13);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 21);
            this.nameTb.TabIndex = 11;
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(188, 145);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(75, 23);
            this.cancelBt.TabIndex = 10;
            this.cancelBt.Text = "取消";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // okBt
            // 
            this.okBt.Location = new System.Drawing.Point(39, 145);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(75, 23);
            this.okBt.TabIndex = 9;
            this.okBt.Text = "确定";
            this.okBt.UseVisualStyleBackColor = true;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // imgPB
            // 
            this.imgPB.Image = global::cyCJ.Resource.nopictype;
            this.imgPB.Location = new System.Drawing.Point(135, 70);
            this.imgPB.Margin = new System.Windows.Forms.Padding(2);
            this.imgPB.Name = "imgPB";
            this.imgPB.Size = new System.Drawing.Size(91, 67);
            this.imgPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPB.TabIndex = 16;
            this.imgPB.TabStop = false;
            this.imgPB.DoubleClick += new System.EventHandler(this.imgPB_DoubleClick);
            // 
            // numTb
            // 
            this.numTb.Location = new System.Drawing.Point(220, 13);
            this.numTb.Name = "numTb";
            this.numTb.Size = new System.Drawing.Size(100, 21);
            this.numTb.TabIndex = 18;
            this.numTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTb_KeyPress);
            // 
            // EditPrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 175);
            this.Controls.Add(this.numTb);
            this.Controls.Add(this.clearImageBt);
            this.Controls.Add(this.imgPB);
            this.Controls.Add(this.addimageBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.okBt);
            this.Controls.Add(this.label1);
            this.Name = "EditPrizeForm";
            this.Text = "EditPrizeForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearImageBt;
        private System.Windows.Forms.PictureBox imgPB;
        private System.Windows.Forms.Button addimageBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button okBt;
        private System.Windows.Forms.TextBox numTb;
    }
}