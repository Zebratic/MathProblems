
namespace MathProblems
{
    partial class Math
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Math));
            this.lblProblem = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.nmDigits = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDigits = new System.Windows.Forms.Label();
            this.lblCorrectWrong = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmDigits)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProblem
            // 
            this.lblProblem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProblem.Font = new System.Drawing.Font("Berlin Sans FB Demi", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblem.Location = new System.Drawing.Point(0, 0);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(848, 76);
            this.lblProblem.TabIndex = 0;
            this.lblProblem.Text = "?? + ?? = ??";
            this.lblProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswer1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.Location = new System.Drawing.Point(15, 136);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(200, 49);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "Answer1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswer2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.Location = new System.Drawing.Point(221, 136);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(200, 49);
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Text = "Answer2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswer3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.Location = new System.Drawing.Point(427, 136);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(200, 49);
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Text = "Answer3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswer4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.Location = new System.Drawing.Point(633, 136);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(200, 49);
            this.btnAnswer4.TabIndex = 4;
            this.btnAnswer4.Text = "Answer4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // cbMode
            // 
            this.cbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiply",
            "Division"});
            this.cbMode.Location = new System.Drawing.Point(728, 1);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(121, 21);
            this.cbMode.TabIndex = 5;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // nmDigits
            // 
            this.nmDigits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmDigits.Location = new System.Drawing.Point(728, 21);
            this.nmDigits.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmDigits.Name = "nmDigits";
            this.nmDigits.Size = new System.Drawing.Size(121, 20);
            this.nmDigits.TabIndex = 6;
            this.nmDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmDigits.ValueChanged += new System.EventHandler(this.nmDigits_ValueChanged);
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(694, 4);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type:";
            // 
            // lblDigits
            // 
            this.lblDigits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDigits.AutoSize = true;
            this.lblDigits.Location = new System.Drawing.Point(692, 23);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(36, 13);
            this.lblDigits.TabIndex = 8;
            this.lblDigits.Text = "Digits:";
            // 
            // lblCorrectWrong
            // 
            this.lblCorrectWrong.AutoSize = true;
            this.lblCorrectWrong.Location = new System.Drawing.Point(12, 4);
            this.lblCorrectWrong.Name = "lblCorrectWrong";
            this.lblCorrectWrong.Size = new System.Drawing.Size(96, 26);
            this.lblCorrectWrong.TabIndex = 9;
            this.lblCorrectWrong.Text = "Correct Answers: 0\r\nWrong Answers: 0\r\n";
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBackground.Controls.Add(this.lblProblem);
            this.pnlBackground.Location = new System.Drawing.Point(1, 45);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(848, 76);
            this.pnlBackground.TabIndex = 10;
            // 
            // Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 197);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.lblCorrectWrong);
            this.Controls.Add(this.lblDigits);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.nmDigits);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(865, 236);
            this.Name = "Math";
            this.Text = "W";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmDigits)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.NumericUpDown nmDigits;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.Label lblCorrectWrong;
        private System.Windows.Forms.Panel pnlBackground;
    }
}

