
namespace DeweyDecimalClassification
{
    partial class FindingCallNo
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.descHeadingLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(39, 44);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(371, 48);
            this.lblHeading.TabIndex = 13;
            this.lblHeading.Text = "Finding Call Numbers";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Location = new System.Drawing.Point(39, 214);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(455, 25);
            this.descriptionLbl.TabIndex = 14;
            this.descriptionLbl.Text = "Description";
            this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(544, 33);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 16;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(136, 410);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(112, 34);
            this.checkBtn.TabIndex = 17;
            this.checkBtn.Text = "Check!";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // descHeadingLbl
            // 
            this.descHeadingLbl.AutoSize = true;
            this.descHeadingLbl.Location = new System.Drawing.Point(39, 164);
            this.descHeadingLbl.Name = "descHeadingLbl";
            this.descHeadingLbl.Size = new System.Drawing.Size(209, 25);
            this.descHeadingLbl.TabIndex = 18;
            this.descHeadingLbl.Text = "Call Number Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Answer:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(596, 59);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(79, 30);
            this.lblPoints.TabIndex = 21;
            this.lblPoints.Text = "Points:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(696, 59);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 30);
            this.lblScore.TabIndex = 22;
            this.lblScore.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(414, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FindingCallNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 533);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descHeadingLbl);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.lblHeading);
            this.Name = "FindingCallNo";
            this.Text = "Finding Call Numbers";
            this.Load += new System.EventHandler(this.FindingCallNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label descHeadingLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
    }
}