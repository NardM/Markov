namespace Algoritm_Markova
{
    partial class connectTheLeft
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
            this.label2 = new System.Windows.Forms.Label();
            this.wordText = new System.Windows.Forms.TextBox();
            this.attachableText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заданное слово: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Слово присоединяемое:";
            // 
            // wordText
            // 
            this.wordText.Enabled = false;
            this.wordText.Location = new System.Drawing.Point(180, 17);
            this.wordText.Name = "wordText";
            this.wordText.Size = new System.Drawing.Size(100, 20);
            this.wordText.TabIndex = 2;
            // 
            // attachableText
            // 
            this.attachableText.Location = new System.Drawing.Point(180, 56);
            this.attachableText.Name = "attachableText";
            this.attachableText.Size = new System.Drawing.Size(100, 20);
            this.attachableText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Полученное слово: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(180, 96);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 5;
            // 
            // connectTheLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 343);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attachableText);
            this.Controls.Add(this.wordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "connectTheLeft";
            this.Text = "Присоединить слово слева";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wordText;
        private System.Windows.Forms.TextBox attachableText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
    }
}