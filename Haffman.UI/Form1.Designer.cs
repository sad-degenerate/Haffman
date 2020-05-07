namespace Haffman.UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbxText = new System.Windows.Forms.RichTextBox();
            this.rtbxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 383);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(288, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbxText
            // 
            this.rtbxText.Location = new System.Drawing.Point(12, 12);
            this.rtbxText.Name = "rtbxText";
            this.rtbxText.Size = new System.Drawing.Size(288, 167);
            this.rtbxText.TabIndex = 1;
            this.rtbxText.Text = "";
            // 
            // rtbxResult
            // 
            this.rtbxResult.Location = new System.Drawing.Point(12, 185);
            this.rtbxResult.Name = "rtbxResult";
            this.rtbxResult.Size = new System.Drawing.Size(288, 167);
            this.rtbxResult.TabIndex = 2;
            this.rtbxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 433);
            this.Controls.Add(this.rtbxResult);
            this.Controls.Add(this.rtbxText);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Haffman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbxText;
        private System.Windows.Forms.RichTextBox rtbxResult;
    }
}

