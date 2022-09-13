namespace GreenvilleRevenueGUI
{
    partial class Form1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.thisYearContestantsTxt = new System.Windows.Forms.TextBox();
            this.lastYearContestantsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.displayResultlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(85, 133);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(85, 183);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // thisYearContestantsTxt
            // 
            this.thisYearContestantsTxt.Location = new System.Drawing.Point(85, 80);
            this.thisYearContestantsTxt.Name = "thisYearContestantsTxt";
            this.thisYearContestantsTxt.Size = new System.Drawing.Size(100, 20);
            this.thisYearContestantsTxt.TabIndex = 2;
            // 
            // lastYearContestantsTxt
            // 
            this.lastYearContestantsTxt.Location = new System.Drawing.Point(265, 80);
            this.lastYearContestantsTxt.Name = "lastYearContestantsTxt";
            this.lastYearContestantsTxt.Size = new System.Drawing.Size(100, 20);
            this.lastYearContestantsTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the number of contestants in the corresponding box and press Calculate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(82, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "This Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(262, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Year";
            // 
            // Resultlbl
            // 
            this.Resultlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Resultlbl.Location = new System.Drawing.Point(265, 133);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(574, 318);
            this.Resultlbl.TabIndex = 7;
            // 
            // displayResultlbl
            // 
            this.displayResultlbl.AutoSize = true;
            this.displayResultlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.displayResultlbl.Location = new System.Drawing.Point(207, 135);
            this.displayResultlbl.Name = "displayResultlbl";
            this.displayResultlbl.Size = new System.Drawing.Size(52, 17);
            this.displayResultlbl.TabIndex = 8;
            this.displayResultlbl.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 461);
            this.Controls.Add(this.displayResultlbl);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastYearContestantsTxt);
            this.Controls.Add(this.thisYearContestantsTxt);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox thisYearContestantsTxt;
        private System.Windows.Forms.TextBox lastYearContestantsTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Label displayResultlbl;
    }
}

