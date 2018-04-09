namespace cyCJ
{
    partial class DrawPrizeForm
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
            this.components = new System.ComponentModel.Container();
            this.showPic = new System.Windows.Forms.PictureBox();
            this.exitBt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startBt = new System.Windows.Forms.Button();
            this.prizeCB = new System.Windows.Forms.ComboBox();
            this.stopBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            this.SuspendLayout();
            // 
            // showPic
            // 
            this.showPic.Location = new System.Drawing.Point(0, 0);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(429, 312);
            this.showPic.TabIndex = 0;
            this.showPic.TabStop = false;
            this.showPic.Click += new System.EventHandler(this.showPic_Click);
            this.showPic.Paint += new System.Windows.Forms.PaintEventHandler(this.showPic_Paint);
            // 
            // exitBt
            // 
            this.exitBt.Location = new System.Drawing.Point(594, 289);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(114, 67);
            this.exitBt.TabIndex = 1;
            this.exitBt.Text = "退出";
            this.exitBt.UseVisualStyleBackColor = true;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 13;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startBt
            // 
            this.startBt.Location = new System.Drawing.Point(234, 289);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(114, 67);
            this.startBt.TabIndex = 2;
            this.startBt.Text = "开始";
            this.startBt.UseVisualStyleBackColor = true;
            this.startBt.Click += new System.EventHandler(this.startBt_Click);
            // 
            // prizeCB
            // 
            this.prizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prizeCB.FormattingEnabled = true;
            this.prizeCB.Location = new System.Drawing.Point(0, 317);
            this.prizeCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prizeCB.Name = "prizeCB";
            this.prizeCB.Size = new System.Drawing.Size(140, 20);
            this.prizeCB.TabIndex = 3;
            // 
            // stopBt
            // 
            this.stopBt.Location = new System.Drawing.Point(474, 289);
            this.stopBt.Name = "stopBt";
            this.stopBt.Size = new System.Drawing.Size(114, 67);
            this.stopBt.TabIndex = 4;
            this.stopBt.Text = "停止";
            this.stopBt.UseVisualStyleBackColor = true;
            this.stopBt.Click += new System.EventHandler(this.stopBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(354, 289);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(114, 67);
            this.cancelBt.TabIndex = 5;
            this.cancelBt.Text = "暂停";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // DrawPrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(744, 368);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.stopBt);
            this.Controls.Add(this.prizeCB);
            this.Controls.Add(this.startBt);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.showPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrawPrizeForm";
            this.ShowIcon = false;
            this.Text = "DrawPrizeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DrawPrizeForm_FormClosed);
            this.Load += new System.EventHandler(this.DrawPrizeForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPrizeForm_Paint);
            this.Resize += new System.EventHandler(this.DrawPrizeForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox showPic;
        private System.Windows.Forms.Button exitBt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startBt;
        private System.Windows.Forms.ComboBox prizeCB;
        private System.Windows.Forms.Button stopBt;
        private System.Windows.Forms.Button cancelBt;
    }
}