
namespace DeweyDecimalClassification
{
    partial class ReplaceBooks
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
            this.ltbNumbers = new System.Windows.Forms.ListBox();
            this.ltbArrange = new System.Windows.Forms.ListBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.mRightBtn = new System.Windows.Forms.Button();
            this.mLeftBtn = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblArrange = new System.Windows.Forms.Label();
            this.ltbCheck = new System.Windows.Forms.ListBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.grpArrange = new System.Windows.Forms.GroupBox();
            this.gpbCheck = new System.Windows.Forms.GroupBox();
            this.grpArrange.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbNumbers
            // 
            this.ltbNumbers.FormattingEnabled = true;
            this.ltbNumbers.ItemHeight = 25;
            this.ltbNumbers.Location = new System.Drawing.Point(49, 188);
            this.ltbNumbers.Name = "ltbNumbers";
            this.ltbNumbers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ltbNumbers.Size = new System.Drawing.Size(250, 279);
            this.ltbNumbers.TabIndex = 0;
            // 
            // ltbArrange
            // 
            this.ltbArrange.FormattingEnabled = true;
            this.ltbArrange.ItemHeight = 25;
            this.ltbArrange.Location = new System.Drawing.Point(439, 188);
            this.ltbArrange.Name = "ltbArrange";
            this.ltbArrange.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ltbArrange.Size = new System.Drawing.Size(250, 279);
            this.ltbArrange.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(879, 494);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(148, 57);
            this.checkBtn.TabIndex = 4;
            this.checkBtn.Text = "Double Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // mRightBtn
            // 
            this.mRightBtn.Location = new System.Drawing.Point(345, 248);
            this.mRightBtn.Name = "mRightBtn";
            this.mRightBtn.Size = new System.Drawing.Size(50, 50);
            this.mRightBtn.TabIndex = 5;
            this.mRightBtn.Text = ">>";
            this.mRightBtn.UseVisualStyleBackColor = true;
            this.mRightBtn.Click += new System.EventHandler(this.mRightBtn_Click);
            // 
            // mLeftBtn
            // 
            this.mLeftBtn.Location = new System.Drawing.Point(345, 356);
            this.mLeftBtn.Name = "mLeftBtn";
            this.mLeftBtn.Size = new System.Drawing.Size(50, 50);
            this.mLeftBtn.TabIndex = 6;
            this.mLeftBtn.Text = "<<";
            this.mLeftBtn.UseVisualStyleBackColor = true;
            this.mLeftBtn.Click += new System.EventHandler(this.mLeftBtn_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(20, 42);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(148, 30);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Call Numbers:";
            // 
            // lblArrange
            // 
            this.lblArrange.AutoSize = true;
            this.lblArrange.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArrange.Location = new System.Drawing.Point(410, 42);
            this.lblArrange.Name = "lblArrange";
            this.lblArrange.Size = new System.Drawing.Size(225, 30);
            this.lblArrange.TabIndex = 8;
            this.lblArrange.Text = "Rearranged Numbers:";
            // 
            // ltbCheck
            // 
            this.ltbCheck.FormattingEnabled = true;
            this.ltbCheck.ItemHeight = 25;
            this.ltbCheck.Location = new System.Drawing.Point(821, 188);
            this.ltbCheck.Name = "ltbCheck";
            this.ltbCheck.Size = new System.Drawing.Size(250, 279);
            this.ltbCheck.TabIndex = 9;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(279, 399);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(148, 57);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheck.Location = new System.Drawing.Point(821, 137);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(86, 30);
            this.lblCheck.TabIndex = 11;
            this.lblCheck.Text = "Output:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(49, 29);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(283, 48);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Replacing Books";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(961, 43);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(79, 30);
            this.lblPoints.TabIndex = 13;
            this.lblPoints.Text = "Points:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(1046, 43);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(25, 30);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "0";
            // 
            // grpArrange
            // 
            this.grpArrange.Controls.Add(this.lblNumber);
            this.grpArrange.Controls.Add(this.lblArrange);
            this.grpArrange.Controls.Add(this.saveBtn);
            this.grpArrange.Location = new System.Drawing.Point(29, 95);
            this.grpArrange.Name = "grpArrange";
            this.grpArrange.Size = new System.Drawing.Size(695, 485);
            this.grpArrange.TabIndex = 15;
            this.grpArrange.TabStop = false;
            this.grpArrange.Text = "Rearrange your numbers";
            // 
            // gpbCheck
            // 
            this.gpbCheck.Location = new System.Drawing.Point(778, 95);
            this.gpbCheck.Name = "gpbCheck";
            this.gpbCheck.Size = new System.Drawing.Size(335, 485);
            this.gpbCheck.TabIndex = 16;
            this.gpbCheck.TabStop = false;
            this.gpbCheck.Text = "Double check your call number order";
            // 
            // ReplaceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 608);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.ltbCheck);
            this.Controls.Add(this.mLeftBtn);
            this.Controls.Add(this.mRightBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.ltbArrange);
            this.Controls.Add(this.ltbNumbers);
            this.Controls.Add(this.grpArrange);
            this.Controls.Add(this.gpbCheck);
            this.Name = "ReplaceBooks";
            this.Text = "ReplaceBooks";
            this.Load += new System.EventHandler(this.ReplaceBooks_Load);
            this.grpArrange.ResumeLayout(false);
            this.grpArrange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbNumbers;
        private System.Windows.Forms.ListBox ltbArrange;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button mRightBtn;
        private System.Windows.Forms.Button mLeftBtn;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblArrange;
        private System.Windows.Forms.ListBox ltbCheck;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox grpArrange;
        private System.Windows.Forms.GroupBox gpbCheck;
    }
}