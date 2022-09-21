
namespace DeweyDecimalClassification
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.replaceBooks = new System.Windows.Forms.Button();
            this.identifyArea = new System.Windows.Forms.Button();
            this.findCallNos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // replaceBooks
            // 
            this.replaceBooks.Location = new System.Drawing.Point(26, 180);
            this.replaceBooks.Name = "replaceBooks";
            this.replaceBooks.Size = new System.Drawing.Size(112, 72);
            this.replaceBooks.TabIndex = 0;
            this.replaceBooks.Text = "Replacing Books";
            this.replaceBooks.UseVisualStyleBackColor = true;
            this.replaceBooks.Click += new System.EventHandler(this.replaceBooks_Click);
            // 
            // identifyArea
            // 
            this.identifyArea.Location = new System.Drawing.Point(213, 180);
            this.identifyArea.Name = "identifyArea";
            this.identifyArea.Size = new System.Drawing.Size(112, 72);
            this.identifyArea.TabIndex = 1;
            this.identifyArea.Text = "Identifying Areas";
            this.identifyArea.UseVisualStyleBackColor = true;
            // 
            // findCallNos
            // 
            this.findCallNos.Location = new System.Drawing.Point(394, 180);
            this.findCallNos.Name = "findCallNos";
            this.findCallNos.Size = new System.Drawing.Size(112, 72);
            this.findCallNos.TabIndex = 2;
            this.findCallNos.Text = "Finding Call Numbers";
            this.findCallNos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(196, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findCallNos);
            this.Controls.Add(this.identifyArea);
            this.Controls.Add(this.replaceBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button replaceBooks;
        private System.Windows.Forms.Button identifyArea;
        private System.Windows.Forms.Button findCallNos;
        private System.Windows.Forms.Label label1;
    }
}

