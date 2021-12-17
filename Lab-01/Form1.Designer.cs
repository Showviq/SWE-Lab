namespace Calculator
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
            this.Add = new System.Windows.Forms.Button();
            this.First_nameText = new System.Windows.Forms.TextBox();
            this.SecondNameText = new System.Windows.Forms.TextBox();
            this.Second_Name = new System.Windows.Forms.Label();
            this.First_name = new System.Windows.Forms.Label();
            this.Final_Value = new System.Windows.Forms.TextBox();
            this.Sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(103, 216);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // First_nameText
            // 
            this.First_nameText.Location = new System.Drawing.Point(123, 58);
            this.First_nameText.Name = "First_nameText";
            this.First_nameText.Size = new System.Drawing.Size(100, 22);
            this.First_nameText.TabIndex = 1;
            // 
            // SecondNameText
            // 
            this.SecondNameText.Location = new System.Drawing.Point(123, 108);
            this.SecondNameText.Name = "SecondNameText";
            this.SecondNameText.Size = new System.Drawing.Size(100, 22);
            this.SecondNameText.TabIndex = 2;
            // 
            // Second_Name
            // 
            this.Second_Name.AutoSize = true;
            this.Second_Name.Location = new System.Drawing.Point(12, 111);
            this.Second_Name.Name = "Second_Name";
            this.Second_Name.Size = new System.Drawing.Size(105, 16);
            this.Second_Name.TabIndex = 3;
            this.Second_Name.Text = "Second Number";
            // 
            // First_name
            // 
            this.First_name.AutoSize = true;
            this.First_name.Location = new System.Drawing.Point(12, 58);
            this.First_name.Name = "First_name";
            this.First_name.Size = new System.Drawing.Size(83, 16);
            this.First_name.TabIndex = 4;
            this.First_name.Text = "First Number";
            this.First_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // Final_Value
            // 
            this.Final_Value.Location = new System.Drawing.Point(215, 216);
            this.Final_Value.Name = "Final_Value";
            this.Final_Value.Size = new System.Drawing.Size(100, 22);
            this.Final_Value.TabIndex = 5;
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(385, 216);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 23);
            this.Sub.TabIndex = 6;
            this.Sub.Text = "Sub";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Final_Value);
            this.Controls.Add(this.First_name);
            this.Controls.Add(this.Second_Name);
            this.Controls.Add(this.SecondNameText);
            this.Controls.Add(this.First_nameText);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox First_nameText;
        private System.Windows.Forms.TextBox SecondNameText;
        private System.Windows.Forms.Label Second_Name;
        private System.Windows.Forms.Label First_name;
        private System.Windows.Forms.TextBox Final_Value;
        private System.Windows.Forms.Button Sub;
    }
}

