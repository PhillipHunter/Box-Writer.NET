namespace Box_Writer
{
    partial class FormMain
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.txtSpacing = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtBox = new System.Windows.Forms.RichTextBox();
            this.btnBoxify = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(90, 57);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(194, 20);
            this.txtWord.TabIndex = 0;
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(90, 83);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(194, 20);
            this.txtLabel.TabIndex = 1;
            // 
            // txtSpacing
            // 
            this.txtSpacing.Location = new System.Drawing.Point(90, 109);
            this.txtSpacing.Name = "txtSpacing";
            this.txtSpacing.Size = new System.Drawing.Size(194, 20);
            this.txtSpacing.TabIndex = 2;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(90, 135);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(194, 20);
            this.txtOffset.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Spacing:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Offset:";
            // 
            // rtxtBox
            // 
            this.rtxtBox.Location = new System.Drawing.Point(290, 57);
            this.rtxtBox.Name = "rtxtBox";
            this.rtxtBox.ReadOnly = true;
            this.rtxtBox.Size = new System.Drawing.Size(514, 426);
            this.rtxtBox.TabIndex = 8;
            this.rtxtBox.Text = "";
            // 
            // btnBoxify
            // 
            this.btnBoxify.Location = new System.Drawing.Point(382, 489);
            this.btnBoxify.Name = "btnBoxify";
            this.btnBoxify.Size = new System.Drawing.Size(75, 23);
            this.btnBoxify.TabIndex = 9;
            this.btnBoxify.Text = "Boxify";
            this.btnBoxify.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(463, 489);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(729, 489);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 518);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnBoxify);
            this.Controls.Add(this.rtxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.txtSpacing);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.txtWord);
            this.Name = "FormMain";
            this.Text = "Box-Writer.NET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.TextBox txtSpacing;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtBox;
        private System.Windows.Forms.Button btnBoxify;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnNew;
    }
}

