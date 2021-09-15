namespace GTDialog
{
    partial class _2see
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
            this.label1 = new System.Windows.Forms.Label();
            this.errorss = new System.Windows.Forms.ListBox();
            this.all = new System.Windows.Forms.ListBox();
            this.Complete = new System.Windows.Forms.ListBox();
            this.logbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Button();
            this.Page2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // errorss
            // 
            this.errorss.FormattingEnabled = true;
            this.errorss.Location = new System.Drawing.Point(12, 170);
            this.errorss.Name = "errorss";
            this.errorss.Size = new System.Drawing.Size(375, 95);
            this.errorss.TabIndex = 2;
            // 
            // all
            // 
            this.all.FormattingEnabled = true;
            this.all.Location = new System.Drawing.Point(12, 284);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(375, 95);
            this.all.TabIndex = 3;
            // 
            // Complete
            // 
            this.Complete.FormattingEnabled = true;
            this.Complete.Location = new System.Drawing.Point(12, 56);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(375, 95);
            this.Complete.TabIndex = 4;
            // 
            // logbox
            // 
            this.logbox.FormattingEnabled = true;
            this.logbox.Location = new System.Drawing.Point(393, 56);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(279, 290);
            this.logbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Complete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Errors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "All";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Logs";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(547, 356);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(125, 23);
            this.Info.TabIndex = 10;
            this.Info.Text = "About Version";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Page2
            // 
            this.Page2.Location = new System.Drawing.Point(396, 356);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(145, 23);
            this.Page2.TabIndex = 11;
            this.Page2.Text = "Page2";
            this.Page2.UseVisualStyleBackColor = true;
            this.Page2.Click += new System.EventHandler(this.Page2_Click);
            // 
            // _2see
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 385);
            this.Controls.Add(this.Page2);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.all);
            this.Controls.Add(this.errorss);
            this.Controls.Add(this.label1);
            this.Name = "_2see";
            this.Text = "_2see";
            this.Load += new System.EventHandler(this._2see_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox errorss;
        private System.Windows.Forms.ListBox all;
        private System.Windows.Forms.ListBox Complete;
        private System.Windows.Forms.ListBox logbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Page2;
    }
}