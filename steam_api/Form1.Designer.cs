namespace steam_api
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.idBox = new System.Windows.Forms.TextBox();
            this.actBtn = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(13, 13);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(153, 19);
            this.idBox.TabIndex = 0;
            // 
            // actBtn
            // 
            this.actBtn.Location = new System.Drawing.Point(13, 39);
            this.actBtn.Name = "actBtn";
            this.actBtn.Size = new System.Drawing.Size(153, 23);
            this.actBtn.TabIndex = 1;
            this.actBtn.Text = "実行";
            this.actBtn.UseVisualStyleBackColor = true;
            this.actBtn.Click += new System.EventHandler(this.actBtn_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 87);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(154, 137);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(13, 230);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(154, 19);
            this.nameBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.actBtn);
            this.Controls.Add(this.idBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button actBtn;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox nameBox;
    }
}

