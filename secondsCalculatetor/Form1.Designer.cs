namespace secondsCalculatetor
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_run = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.Label();
            this.box.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(380, 47);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(219, 26);
            this.txt_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Second:";
            // 
            // txt_run
            // 
            this.txt_run.Location = new System.Drawing.Point(627, 35);
            this.txt_run.Name = "txt_run";
            this.txt_run.Size = new System.Drawing.Size(64, 44);
            this.txt_run.TabIndex = 2;
            this.txt_run.Text = "Run";
            this.txt_run.UseVisualStyleBackColor = true;
            this.txt_run.Click += new System.EventHandler(this.button1_Click);
            // 
            // box
            // 
            this.box.Controls.Add(this.result);
            this.box.Location = new System.Drawing.Point(158, 104);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(552, 130);
            this.box.TabIndex = 3;
            this.box.TabStop = false;
            this.box.Text = "Output";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(22, 23);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(524, 103);
            this.result.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.box);
            this.Controls.Add(this.txt_run);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txt_run;
        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.Label result;
    }
}

