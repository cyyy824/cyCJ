namespace cyCJ.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.setPrizeBt = new System.Windows.Forms.Button();
            this.settfBt = new System.Windows.Forms.Button();
            this.setFontCBt = new System.Windows.Forms.Button();
            this.setMBt = new System.Windows.Forms.Button();
            this.showNameCB = new System.Windows.Forms.CheckBox();
            this.updateshowBg = new System.Windows.Forms.Button();
            this.drawPage = new System.Windows.Forms.PictureBox();
            this.drawBt = new System.Windows.Forms.Button();
            this.updateBg = new System.Windows.Forms.Button();
            this.showPage = new System.Windows.Forms.PictureBox();
            this.setPersonBt = new System.Windows.Forms.Button();
            this.winprizeShowBt = new System.Windows.Forms.Button();
            this.drawTypeCB = new System.Windows.Forms.ComboBox();
            this.startTimeTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPage)).BeginInit();
            this.SuspendLayout();
            // 
            // setPrizeBt
            // 
            this.setPrizeBt.Location = new System.Drawing.Point(93, 304);
            this.setPrizeBt.Margin = new System.Windows.Forms.Padding(5);
            this.setPrizeBt.Name = "setPrizeBt";
            this.setPrizeBt.Size = new System.Drawing.Size(250, 79);
            this.setPrizeBt.TabIndex = 32;
            this.setPrizeBt.Text = "抽取项设置";
            this.setPrizeBt.UseVisualStyleBackColor = true;
            this.setPrizeBt.Click += new System.EventHandler(this.setPrizeBt_Click);
            // 
            // settfBt
            // 
            this.settfBt.Location = new System.Drawing.Point(819, 312);
            this.settfBt.Margin = new System.Windows.Forms.Padding(5);
            this.settfBt.Name = "settfBt";
            this.settfBt.Size = new System.Drawing.Size(129, 63);
            this.settfBt.TabIndex = 31;
            this.settfBt.Text = "标题字体";
            this.settfBt.UseVisualStyleBackColor = true;
            this.settfBt.Click += new System.EventHandler(this.settfBt_Click);
            // 
            // setFontCBt
            // 
            this.setFontCBt.Location = new System.Drawing.Point(685, 312);
            this.setFontCBt.Margin = new System.Windows.Forms.Padding(5);
            this.setFontCBt.Name = "setFontCBt";
            this.setFontCBt.Size = new System.Drawing.Size(123, 63);
            this.setFontCBt.TabIndex = 30;
            this.setFontCBt.Text = "内容字体";
            this.setFontCBt.UseVisualStyleBackColor = true;
            this.setFontCBt.Click += new System.EventHandler(this.setFontCBt_Click);
            // 
            // setMBt
            // 
            this.setMBt.Location = new System.Drawing.Point(553, 312);
            this.setMBt.Margin = new System.Windows.Forms.Padding(5);
            this.setMBt.Name = "setMBt";
            this.setMBt.Size = new System.Drawing.Size(120, 63);
            this.setMBt.TabIndex = 29;
            this.setMBt.Text = "位置设置";
            this.setMBt.UseVisualStyleBackColor = true;
            this.setMBt.Click += new System.EventHandler(this.setMBt_Click);
            // 
            // showNameCB
            // 
            this.showNameCB.AutoSize = true;
            this.showNameCB.Location = new System.Drawing.Point(715, 385);
            this.showNameCB.Margin = new System.Windows.Forms.Padding(5);
            this.showNameCB.Name = "showNameCB";
            this.showNameCB.Size = new System.Drawing.Size(256, 35);
            this.showNameCB.TabIndex = 28;
            this.showNameCB.Text = "抽取时是否显示名字";
            this.showNameCB.UseVisualStyleBackColor = true;
            this.showNameCB.CheckedChanged += new System.EventHandler(this.showNameCB_CheckedChanged);
            // 
            // updateshowBg
            // 
            this.updateshowBg.Location = new System.Drawing.Point(409, 26);
            this.updateshowBg.Margin = new System.Windows.Forms.Padding(5);
            this.updateshowBg.Name = "updateshowBg";
            this.updateshowBg.Size = new System.Drawing.Size(139, 77);
            this.updateshowBg.TabIndex = 27;
            this.updateshowBg.Text = "<-更换展示背景";
            this.updateshowBg.UseVisualStyleBackColor = true;
            this.updateshowBg.Click += new System.EventHandler(this.updateshowBg_Click);
            // 
            // drawPage
            // 
            this.drawPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawPage.Location = new System.Drawing.Point(553, 3);
            this.drawPage.Margin = new System.Windows.Forms.Padding(5);
            this.drawPage.Name = "drawPage";
            this.drawPage.Size = new System.Drawing.Size(398, 293);
            this.drawPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drawPage.TabIndex = 26;
            this.drawPage.TabStop = false;
            // 
            // drawBt
            // 
            this.drawBt.Location = new System.Drawing.Point(637, 483);
            this.drawBt.Margin = new System.Windows.Forms.Padding(5);
            this.drawBt.Name = "drawBt";
            this.drawBt.Size = new System.Drawing.Size(200, 102);
            this.drawBt.TabIndex = 22;
            this.drawBt.Text = "开始抽取";
            this.drawBt.UseVisualStyleBackColor = true;
            this.drawBt.Click += new System.EventHandler(this.drawBt_Click);
            // 
            // updateBg
            // 
            this.updateBg.Location = new System.Drawing.Point(409, 157);
            this.updateBg.Margin = new System.Windows.Forms.Padding(5);
            this.updateBg.Name = "updateBg";
            this.updateBg.Size = new System.Drawing.Size(134, 73);
            this.updateBg.TabIndex = 20;
            this.updateBg.Text = "更换抽取背景->";
            this.updateBg.UseVisualStyleBackColor = true;
            this.updateBg.Click += new System.EventHandler(this.updateBg_Click);
            // 
            // showPage
            // 
            this.showPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showPage.Location = new System.Drawing.Point(6, 3);
            this.showPage.Margin = new System.Windows.Forms.Padding(5);
            this.showPage.Name = "showPage";
            this.showPage.Size = new System.Drawing.Size(398, 291);
            this.showPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPage.TabIndex = 19;
            this.showPage.TabStop = false;
            // 
            // setPersonBt
            // 
            this.setPersonBt.Location = new System.Drawing.Point(93, 396);
            this.setPersonBt.Margin = new System.Windows.Forms.Padding(5);
            this.setPersonBt.Name = "setPersonBt";
            this.setPersonBt.Size = new System.Drawing.Size(250, 79);
            this.setPersonBt.TabIndex = 33;
            this.setPersonBt.Text = "抽奖人员设置";
            this.setPersonBt.UseVisualStyleBackColor = true;
            this.setPersonBt.Click += new System.EventHandler(this.setPersonBt_Click);
            // 
            // winprizeShowBt
            // 
            this.winprizeShowBt.Location = new System.Drawing.Point(93, 486);
            this.winprizeShowBt.Margin = new System.Windows.Forms.Padding(5);
            this.winprizeShowBt.Name = "winprizeShowBt";
            this.winprizeShowBt.Size = new System.Drawing.Size(250, 79);
            this.winprizeShowBt.TabIndex = 35;
            this.winprizeShowBt.Text = "抽奖结果查看";
            this.winprizeShowBt.UseVisualStyleBackColor = true;
            this.winprizeShowBt.Click += new System.EventHandler(this.winprizeShowBt_Click);
            // 
            // drawTypeCB
            // 
            this.drawTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drawTypeCB.FormattingEnabled = true;
            this.drawTypeCB.Items.AddRange(new object[] {
            "以姓名抽取",
            "以感悟抽取"});
            this.drawTypeCB.Location = new System.Drawing.Point(553, 385);
            this.drawTypeCB.Name = "drawTypeCB";
            this.drawTypeCB.Size = new System.Drawing.Size(121, 39);
            this.drawTypeCB.TabIndex = 36;
            this.drawTypeCB.SelectedIndexChanged += new System.EventHandler(this.drawTypeCB_SelectedIndexChanged);
            // 
            // startTimeTP
            // 
            this.startTimeTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeTP.Location = new System.Drawing.Point(553, 432);
            this.startTimeTP.Name = "startTimeTP";
            this.startTimeTP.Size = new System.Drawing.Size(200, 39);
            this.startTimeTP.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "开始抽奖时间";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTimeTP);
            this.Controls.Add(this.drawTypeCB);
            this.Controls.Add(this.winprizeShowBt);
            this.Controls.Add(this.setPersonBt);
            this.Controls.Add(this.setPrizeBt);
            this.Controls.Add(this.settfBt);
            this.Controls.Add(this.setFontCBt);
            this.Controls.Add(this.setMBt);
            this.Controls.Add(this.showNameCB);
            this.Controls.Add(this.updateshowBg);
            this.Controls.Add(this.drawPage);
            this.Controls.Add(this.drawBt);
            this.Controls.Add(this.updateBg);
            this.Controls.Add(this.showPage);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "抽奖设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button setPrizeBt;
        private System.Windows.Forms.Button settfBt;
        private System.Windows.Forms.Button setFontCBt;
        private System.Windows.Forms.Button setMBt;
        private System.Windows.Forms.CheckBox showNameCB;
        private System.Windows.Forms.Button updateshowBg;
        private System.Windows.Forms.PictureBox drawPage;
        private System.Windows.Forms.Button drawBt;
        private System.Windows.Forms.Button updateBg;
        private System.Windows.Forms.PictureBox showPage;
        private System.Windows.Forms.Button setPersonBt;
        private System.Windows.Forms.Button winprizeShowBt;
        private System.Windows.Forms.ComboBox drawTypeCB;
        private System.Windows.Forms.DateTimePicker startTimeTP;
        private System.Windows.Forms.Label label1;
    }
}

