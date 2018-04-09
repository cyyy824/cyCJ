namespace cyCJ
{
    partial class WinPrizeShowForm
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
            this.prizeLv = new System.Windows.Forms.ListView();
            this.personLv = new System.Windows.Forms.ListView();
            this.startTimeTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endTimeTP = new System.Windows.Forms.DateTimePicker();
            this.searchBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.exportBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prizeLv
            // 
            this.prizeLv.Location = new System.Drawing.Point(12, 12);
            this.prizeLv.Name = "prizeLv";
            this.prizeLv.Size = new System.Drawing.Size(215, 500);
            this.prizeLv.TabIndex = 0;
            this.prizeLv.UseCompatibleStateImageBehavior = false;
            this.prizeLv.View = System.Windows.Forms.View.Details;
            this.prizeLv.SelectedIndexChanged += new System.EventHandler(this.prizeLv_SelectedIndexChanged);
            // 
            // personLv
            // 
            this.personLv.Location = new System.Drawing.Point(233, 12);
            this.personLv.Name = "personLv";
            this.personLv.Size = new System.Drawing.Size(904, 500);
            this.personLv.TabIndex = 1;
            this.personLv.UseCompatibleStateImageBehavior = false;
            this.personLv.View = System.Windows.Forms.View.Details;
            // 
            // startTimeTP
            // 
            this.startTimeTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeTP.Location = new System.Drawing.Point(103, 519);
            this.startTimeTP.Name = "startTimeTP";
            this.startTimeTP.Size = new System.Drawing.Size(200, 28);
            this.startTimeTP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "截止时间：";
            // 
            // endTimeTP
            // 
            this.endTimeTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeTP.Location = new System.Drawing.Point(415, 520);
            this.endTimeTP.Name = "endTimeTP";
            this.endTimeTP.Size = new System.Drawing.Size(200, 28);
            this.endTimeTP.TabIndex = 5;
            // 
            // searchBt
            // 
            this.searchBt.Location = new System.Drawing.Point(624, 519);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(85, 35);
            this.searchBt.TabIndex = 6;
            this.searchBt.Text = "搜索";
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(815, 518);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(85, 35);
            this.cancelBt.TabIndex = 7;
            this.cancelBt.Text = "返回";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // exportBt
            // 
            this.exportBt.Location = new System.Drawing.Point(720, 518);
            this.exportBt.Name = "exportBt";
            this.exportBt.Size = new System.Drawing.Size(85, 35);
            this.exportBt.TabIndex = 8;
            this.exportBt.Text = "导出";
            this.exportBt.UseVisualStyleBackColor = true;
            this.exportBt.Click += new System.EventHandler(this.exportBt_Click);
            // 
            // WinPrizeShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 590);
            this.Controls.Add(this.exportBt);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.endTimeTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTimeTP);
            this.Controls.Add(this.personLv);
            this.Controls.Add(this.prizeLv);
            this.Controls.Add(this.label1);
            this.Name = "WinPrizeShowForm";
            this.Text = "抽奖结果展示";
            this.Load += new System.EventHandler(this.WinPrizeShowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prizeLv;
        private System.Windows.Forms.ListView personLv;
        private System.Windows.Forms.DateTimePicker startTimeTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endTimeTP;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button exportBt;
    }
}