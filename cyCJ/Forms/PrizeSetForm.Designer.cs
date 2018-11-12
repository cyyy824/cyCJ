namespace cyCJ.Forms
{
    partial class PrizeSetForm
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
            this.backBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.prizeListLv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(306, 298);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(75, 34);
            this.backBt.TabIndex = 9;
            this.backBt.Text = "返回";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(202, 298);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(75, 34);
            this.deleteBt.TabIndex = 8;
            this.deleteBt.Text = "删除";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Location = new System.Drawing.Point(105, 298);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(75, 34);
            this.updateBt.TabIndex = 7;
            this.updateBt.Text = "修改";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(12, 298);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 34);
            this.addBt.TabIndex = 6;
            this.addBt.Text = "添加";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // prizeListLv
            // 
            this.prizeListLv.AutoArrange = false;
            this.prizeListLv.FullRowSelect = true;
            this.prizeListLv.Location = new System.Drawing.Point(2, 2);
            this.prizeListLv.MultiSelect = false;
            this.prizeListLv.Name = "prizeListLv";
            this.prizeListLv.Size = new System.Drawing.Size(389, 290);
            this.prizeListLv.TabIndex = 5;
            this.prizeListLv.UseCompatibleStateImageBehavior = false;
            this.prizeListLv.View = System.Windows.Forms.View.Details;
            this.prizeListLv.VirtualMode = true;
            this.prizeListLv.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.prizeListLv_RetrieveVirtualItem);
            // 
            // PrizeSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 351);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.prizeListLv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrizeSetForm";
            this.Text = "PrizeSetForm";
            this.Load += new System.EventHandler(this.PrizeSetForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.ListView prizeListLv;
    }
}