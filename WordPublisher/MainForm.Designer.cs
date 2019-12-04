namespace WordPublisher
{
    partial class MainForm
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
            this.tbxDirWord = new System.Windows.Forms.TextBox();
            this.tbxDirPublisher = new System.Windows.Forms.TextBox();
            this.lblDirWord = new System.Windows.Forms.Label();
            this.lblDirPublisher = new System.Windows.Forms.Label();
            this.btnChooseDirWord = new System.Windows.Forms.Button();
            this.lblChooseDirPub = new System.Windows.Forms.Button();
            this.btnTransText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxDirWord
            // 
            this.tbxDirWord.Location = new System.Drawing.Point(12, 51);
            this.tbxDirWord.Name = "tbxDirWord";
            this.tbxDirWord.Size = new System.Drawing.Size(174, 20);
            this.tbxDirWord.TabIndex = 0;
            // 
            // tbxDirPublisher
            // 
            this.tbxDirPublisher.Location = new System.Drawing.Point(12, 98);
            this.tbxDirPublisher.Name = "tbxDirPublisher";
            this.tbxDirPublisher.Size = new System.Drawing.Size(174, 20);
            this.tbxDirPublisher.TabIndex = 1;
            // 
            // lblDirWord
            // 
            this.lblDirWord.AutoSize = true;
            this.lblDirWord.Location = new System.Drawing.Point(13, 32);
            this.lblDirWord.Name = "lblDirWord";
            this.lblDirWord.Size = new System.Drawing.Size(119, 13);
            this.lblDirWord.TabIndex = 2;
            this.lblDirWord.Text = "Директория для Word";
            // 
            // lblDirPublisher
            // 
            this.lblDirPublisher.AutoSize = true;
            this.lblDirPublisher.Location = new System.Drawing.Point(13, 82);
            this.lblDirPublisher.Name = "lblDirPublisher";
            this.lblDirPublisher.Size = new System.Drawing.Size(136, 13);
            this.lblDirPublisher.TabIndex = 3;
            this.lblDirPublisher.Text = "Директория для Publisher";
            // 
            // btnChooseDirWord
            // 
            this.btnChooseDirWord.Location = new System.Drawing.Point(193, 51);
            this.btnChooseDirWord.Name = "btnChooseDirWord";
            this.btnChooseDirWord.Size = new System.Drawing.Size(25, 23);
            this.btnChooseDirWord.TabIndex = 4;
            this.btnChooseDirWord.Text = "...";
            this.btnChooseDirWord.UseVisualStyleBackColor = true;
            // 
            // lblChooseDirPub
            // 
            this.lblChooseDirPub.Location = new System.Drawing.Point(192, 95);
            this.lblChooseDirPub.Name = "lblChooseDirPub";
            this.lblChooseDirPub.Size = new System.Drawing.Size(25, 23);
            this.lblChooseDirPub.TabIndex = 5;
            this.lblChooseDirPub.Text = "...";
            this.lblChooseDirPub.UseVisualStyleBackColor = true;
            // 
            // btnTransText
            // 
            this.btnTransText.Location = new System.Drawing.Point(12, 125);
            this.btnTransText.Name = "btnTransText";
            this.btnTransText.Size = new System.Drawing.Size(75, 23);
            this.btnTransText.TabIndex = 6;
            this.btnTransText.Text = "Перевести";
            this.btnTransText.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 155);
            this.Controls.Add(this.btnTransText);
            this.Controls.Add(this.lblChooseDirPub);
            this.Controls.Add(this.btnChooseDirWord);
            this.Controls.Add(this.lblDirPublisher);
            this.Controls.Add(this.lblDirWord);
            this.Controls.Add(this.tbxDirPublisher);
            this.Controls.Add(this.tbxDirWord);
            this.Name = "MainForm";
            this.Text = "Перевод текста из Word в Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDirWord;
        private System.Windows.Forms.TextBox tbxDirPublisher;
        private System.Windows.Forms.Label lblDirWord;
        private System.Windows.Forms.Label lblDirPublisher;
        private System.Windows.Forms.Button btnChooseDirWord;
        private System.Windows.Forms.Button lblChooseDirPub;
        private System.Windows.Forms.Button btnTransText;
    }
}

