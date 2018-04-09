namespace cyCJ
{
    partial class PersonSetForm
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
            this.deleteBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.clearBt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.importBt = new System.Windows.Forms.Button();
            this.personsLv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // deleteBt
            // 
            this.deleteBt.Location = new System.Drawing.Point(164, 401);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(72, 35);
            this.deleteBt.TabIndex = 24;
            this.deleteBt.Text = "删除";
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Location = new System.Drawing.Point(85, 401);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(72, 35);
            this.updateBt.TabIndex = 23;
            this.updateBt.Text = "修改";
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(6, 401);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(72, 35);
            this.addBt.TabIndex = 22;
            this.addBt.Text = "添加";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // clearBt
            // 
            this.clearBt.Location = new System.Drawing.Point(322, 401);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(72, 35);
            this.clearBt.TabIndex = 21;
            this.clearBt.Text = "清空名单";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "去除已抽取人员";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // importBt
            // 
            this.importBt.Location = new System.Drawing.Point(243, 401);
            this.importBt.Name = "importBt";
            this.importBt.Size = new System.Drawing.Size(72, 35);
            this.importBt.TabIndex = 19;
            this.importBt.Text = "导入名单";
            this.importBt.UseVisualStyleBackColor = true;
            this.importBt.Click += new System.EventHandler(this.importBt_Click);
            // 
            // personsLv
            // 
            this.personsLv.AutoArrange = false;
            this.personsLv.FullRowSelect = true;
            this.personsLv.HideSelection = false;
            this.personsLv.Location = new System.Drawing.Point(7, 12);
            this.personsLv.MultiSelect = false;
            this.personsLv.Name = "personsLv";
            this.personsLv.Size = new System.Drawing.Size(492, 383);
            this.personsLv.TabIndex = 25;
            this.personsLv.UseCompatibleStateImageBehavior = false;
            this.personsLv.View = System.Windows.Forms.View.Details;
            this.personsLv.VirtualMode = true;
            this.personsLv.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.personsLv_RetrieveVirtualItem);
            // 
            // PersonSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 446);
            this.Controls.Add(this.personsLv);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.clearBt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.importBt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "PersonSetForm";
            this.Text = "PersonSetForm";
            this.Load += new System.EventHandler(this.PersonSetForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button importBt;
        private System.Windows.Forms.ListView personsLv;
    }
}