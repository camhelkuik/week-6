namespace Assignment6
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an integer result (1-10) and press Enter:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(199, 846);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(126, 25);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "lblDateTime";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(204, 153);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(188, 31);
            this.inputTextBox.TabIndex = 2;
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(204, 291);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(374, 509);
            this.displayTextBox.TabIndex = 3;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(444, 145);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(134, 46);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(267, 224);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(240, 38);
            this.btnResults.TabIndex = 5;
            this.btnResults.Text = "View Survey Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 985);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnResults;
    }
}

