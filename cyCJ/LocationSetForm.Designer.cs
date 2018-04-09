namespace cyCJ
{
    partial class LocationSetForm
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
            this.drawPage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xTb = new System.Windows.Forms.TextBox();
            this.yTb = new System.Windows.Forms.TextBox();
            this.wTb = new System.Windows.Forms.TextBox();
            this.hTb = new System.Windows.Forms.TextBox();
            this.setMBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.autoCB = new System.Windows.Forms.CheckBox();
            this.isShowCB = new System.Windows.Forms.CheckBox();
            this.okBt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tyTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawPage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPage
            // 
            this.drawPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawPage.Location = new System.Drawing.Point(241, 14);
            this.drawPage.Margin = new System.Windows.Forms.Padding(5);
            this.drawPage.Name = "drawPage";
            this.drawPage.Size = new System.Drawing.Size(398, 293);
            this.drawPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drawPage.TabIndex = 27;
            this.drawPage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "宽";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "高";
            // 
            // xTb
            // 
            this.xTb.Location = new System.Drawing.Point(31, 27);
            this.xTb.Name = "xTb";
            this.xTb.Size = new System.Drawing.Size(47, 28);
            this.xTb.TabIndex = 32;
            this.xTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xTb_KeyPress);
            // 
            // yTb
            // 
            this.yTb.Location = new System.Drawing.Point(132, 27);
            this.yTb.Name = "yTb";
            this.yTb.Size = new System.Drawing.Size(61, 28);
            this.yTb.TabIndex = 33;
            this.yTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yTb_KeyPress);
            // 
            // wTb
            // 
            this.wTb.Location = new System.Drawing.Point(93, 81);
            this.wTb.Name = "wTb";
            this.wTb.Size = new System.Drawing.Size(100, 28);
            this.wTb.TabIndex = 34;
            this.wTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wTb_KeyPress);
            // 
            // hTb
            // 
            this.hTb.Location = new System.Drawing.Point(93, 121);
            this.hTb.Name = "hTb";
            this.hTb.Size = new System.Drawing.Size(100, 28);
            this.hTb.TabIndex = 35;
            this.hTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hTb_KeyPress);
            // 
            // setMBt
            // 
            this.setMBt.Location = new System.Drawing.Point(-2, 161);
            this.setMBt.Margin = new System.Windows.Forms.Padding(5);
            this.setMBt.Name = "setMBt";
            this.setMBt.Size = new System.Drawing.Size(101, 45);
            this.setMBt.TabIndex = 36;
            this.setMBt.Text = "底色设置";
            this.setMBt.UseVisualStyleBackColor = true;
            this.setMBt.Click += new System.EventHandler(this.setMBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Location = new System.Drawing.Point(97, 357);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(81, 52);
            this.updateBt.TabIndex = 37;
            this.updateBt.Text = "刷新";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(422, 357);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(82, 52);
            this.cancelBt.TabIndex = 38;
            this.cancelBt.Text = "取消";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // autoCB
            // 
            this.autoCB.AutoSize = true;
            this.autoCB.Location = new System.Drawing.Point(34, 16);
            this.autoCB.Name = "autoCB";
            this.autoCB.Size = new System.Drawing.Size(124, 22);
            this.autoCB.TabIndex = 39;
            this.autoCB.Text = "自定义位置";
            this.autoCB.UseVisualStyleBackColor = true;
            this.autoCB.CheckedChanged += new System.EventHandler(this.autoCB_CheckedChanged);
            // 
            // isShowCB
            // 
            this.isShowCB.AutoSize = true;
            this.isShowCB.Location = new System.Drawing.Point(105, 178);
            this.isShowCB.Name = "isShowCB";
            this.isShowCB.Size = new System.Drawing.Size(124, 22);
            this.isShowCB.TabIndex = 40;
            this.isShowCB.Text = "画抽奖底色";
            this.isShowCB.UseVisualStyleBackColor = true;
            this.isShowCB.CheckedChanged += new System.EventHandler(this.isShowCB_CheckedChanged);
            // 
            // okBt
            // 
            this.okBt.Location = new System.Drawing.Point(262, 357);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(81, 52);
            this.okBt.TabIndex = 41;
            this.okBt.Text = "确定";
            this.okBt.UseVisualStyleBackColor = true;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.isShowCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.yTb);
            this.groupBox1.Controls.Add(this.wTb);
            this.groupBox1.Controls.Add(this.setMBt);
            this.groupBox1.Controls.Add(this.hTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 212);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "底色";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txTb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tyTb);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "标题";
            // 
            // txTb
            // 
            this.txTb.Location = new System.Drawing.Point(29, 24);
            this.txTb.Name = "txTb";
            this.txTb.Size = new System.Drawing.Size(47, 28);
            this.txTb.TabIndex = 42;
            this.txTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Y";
            // 
            // tyTb
            // 
            this.tyTb.Location = new System.Drawing.Point(130, 24);
            this.tyTb.Name = "tyTb";
            this.tyTb.Size = new System.Drawing.Size(61, 28);
            this.tyTb.TabIndex = 43;
            this.tyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tyTb_KeyPress);
            // 
            // LocationSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.okBt);
            this.Controls.Add(this.autoCB);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.drawPage);
            this.Name = "LocationSetForm";
            this.Text = "LocationSetForm";
            this.Load += new System.EventHandler(this.LocationSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawPage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox drawPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xTb;
        private System.Windows.Forms.TextBox yTb;
        private System.Windows.Forms.TextBox wTb;
        private System.Windows.Forms.TextBox hTb;
        private System.Windows.Forms.Button setMBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.CheckBox autoCB;
        private System.Windows.Forms.CheckBox isShowCB;
        private System.Windows.Forms.Button okBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tyTb;
    }
}