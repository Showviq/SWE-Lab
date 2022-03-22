namespace Sessional_Final
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textInput = new System.Windows.Forms.TextBox();
            this.AttendanceLabel = new System.Windows.Forms.Label();
            this.Quiz1Label = new System.Windows.Forms.Label();
            this.Quiz2Label = new System.Windows.Forms.Label();
            this.Quiz3Label = new System.Windows.Forms.Label();
            this.Quiz4Label = new System.Windows.Forms.Label();
            this.QuizTotalLabel = new System.Windows.Forms.Label();
            this.MidLabel = new System.Windows.Forms.Label();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.VivaLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.AttendanceText = new System.Windows.Forms.Label();
            this.Quiz1Text = new System.Windows.Forms.Label();
            this.Quiz2Text = new System.Windows.Forms.Label();
            this.Quiz3Text = new System.Windows.Forms.Label();
            this.Quiz4Text = new System.Windows.Forms.Label();
            this.QuizTotalText = new System.Windows.Forms.Label();
            this.MidText = new System.Windows.Forms.Label();
            this.FinalText = new System.Windows.Forms.Label();
            this.VivaText = new System.Windows.Forms.Label();
            this.TotalText = new System.Windows.Forms.Label();
            this.PercentageText = new System.Windows.Forms.Label();
            this.GradeText = new System.Windows.Forms.Label();
            this.StudentNameText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(895, 121);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(129, 28);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search By ID";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Percentage,
            this.Grade});
            this.dataGridView1.Location = new System.Drawing.Point(61, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(589, 384);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Percentage
            // 
            this.Percentage.HeaderText = "Percentage";
            this.Percentage.MinimumWidth = 6;
            this.Percentage.Name = "Percentage";
            this.Percentage.Width = 125;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 125;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(781, 89);
            this.textInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(241, 22);
            this.textInput.TabIndex = 2;
            // 
            // AttendanceLabel
            // 
            this.AttendanceLabel.AutoSize = true;
            this.AttendanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceLabel.Location = new System.Drawing.Point(777, 201);
            this.AttendanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttendanceLabel.Name = "AttendanceLabel";
            this.AttendanceLabel.Size = new System.Drawing.Size(100, 24);
            this.AttendanceLabel.TabIndex = 3;
            this.AttendanceLabel.Text = "Attendace:";
            // 
            // Quiz1Label
            // 
            this.Quiz1Label.AutoSize = true;
            this.Quiz1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz1Label.Location = new System.Drawing.Point(777, 223);
            this.Quiz1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz1Label.Name = "Quiz1Label";
            this.Quiz1Label.Size = new System.Drawing.Size(69, 24);
            this.Quiz1Label.TabIndex = 3;
            this.Quiz1Label.Text = "Quiz 1:";
            // 
            // Quiz2Label
            // 
            this.Quiz2Label.AutoSize = true;
            this.Quiz2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz2Label.Location = new System.Drawing.Point(777, 245);
            this.Quiz2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz2Label.Name = "Quiz2Label";
            this.Quiz2Label.Size = new System.Drawing.Size(69, 24);
            this.Quiz2Label.TabIndex = 3;
            this.Quiz2Label.Text = "Quiz 2:";
            // 
            // Quiz3Label
            // 
            this.Quiz3Label.AutoSize = true;
            this.Quiz3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz3Label.Location = new System.Drawing.Point(777, 267);
            this.Quiz3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz3Label.Name = "Quiz3Label";
            this.Quiz3Label.Size = new System.Drawing.Size(69, 24);
            this.Quiz3Label.TabIndex = 3;
            this.Quiz3Label.Text = "Quiz 3:";
            // 
            // Quiz4Label
            // 
            this.Quiz4Label.AutoSize = true;
            this.Quiz4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz4Label.Location = new System.Drawing.Point(777, 289);
            this.Quiz4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz4Label.Name = "Quiz4Label";
            this.Quiz4Label.Size = new System.Drawing.Size(69, 24);
            this.Quiz4Label.TabIndex = 3;
            this.Quiz4Label.Text = "Quiz 4:";
            // 
            // QuizTotalLabel
            // 
            this.QuizTotalLabel.AutoSize = true;
            this.QuizTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizTotalLabel.Location = new System.Drawing.Point(777, 311);
            this.QuizTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuizTotalLabel.Name = "QuizTotalLabel";
            this.QuizTotalLabel.Size = new System.Drawing.Size(168, 24);
            this.QuizTotalLabel.TabIndex = 3;
            this.QuizTotalLabel.Text = "Quiz Total (Best 3):";
            // 
            // MidLabel
            // 
            this.MidLabel.AutoSize = true;
            this.MidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidLabel.Location = new System.Drawing.Point(777, 334);
            this.MidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MidLabel.Name = "MidLabel";
            this.MidLabel.Size = new System.Drawing.Size(46, 24);
            this.MidLabel.TabIndex = 3;
            this.MidLabel.Text = "Mid:";
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalLabel.Location = new System.Drawing.Point(777, 356);
            this.FinalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(56, 24);
            this.FinalLabel.TabIndex = 3;
            this.FinalLabel.Text = "Final:";
            // 
            // VivaLabel
            // 
            this.VivaLabel.AutoSize = true;
            this.VivaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VivaLabel.Location = new System.Drawing.Point(777, 378);
            this.VivaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VivaLabel.Name = "VivaLabel";
            this.VivaLabel.Size = new System.Drawing.Size(51, 24);
            this.VivaLabel.TabIndex = 3;
            this.VivaLabel.Text = "Viva:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(777, 400);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(158, 24);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total (Out of 300):";
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageLabel.Location = new System.Drawing.Point(777, 422);
            this.PercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(112, 24);
            this.PercentageLabel.TabIndex = 3;
            this.PercentageLabel.Text = "Percentage:";
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeLabel.Location = new System.Drawing.Point(777, 444);
            this.GradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(67, 24);
            this.GradeLabel.TabIndex = 3;
            this.GradeLabel.Text = "Grade:";
            // 
            // AttendanceText
            // 
            this.AttendanceText.AutoSize = true;
            this.AttendanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceText.Location = new System.Drawing.Point(888, 201);
            this.AttendanceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AttendanceText.Name = "AttendanceText";
            this.AttendanceText.Size = new System.Drawing.Size(20, 24);
            this.AttendanceText.TabIndex = 3;
            this.AttendanceText.Text = "0";
            // 
            // Quiz1Text
            // 
            this.Quiz1Text.AutoSize = true;
            this.Quiz1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz1Text.Location = new System.Drawing.Point(888, 223);
            this.Quiz1Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz1Text.Name = "Quiz1Text";
            this.Quiz1Text.Size = new System.Drawing.Size(20, 24);
            this.Quiz1Text.TabIndex = 3;
            this.Quiz1Text.Text = "0";
            // 
            // Quiz2Text
            // 
            this.Quiz2Text.AutoSize = true;
            this.Quiz2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz2Text.Location = new System.Drawing.Point(888, 245);
            this.Quiz2Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz2Text.Name = "Quiz2Text";
            this.Quiz2Text.Size = new System.Drawing.Size(20, 24);
            this.Quiz2Text.TabIndex = 3;
            this.Quiz2Text.Text = "0";
            // 
            // Quiz3Text
            // 
            this.Quiz3Text.AutoSize = true;
            this.Quiz3Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz3Text.Location = new System.Drawing.Point(888, 267);
            this.Quiz3Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz3Text.Name = "Quiz3Text";
            this.Quiz3Text.Size = new System.Drawing.Size(20, 24);
            this.Quiz3Text.TabIndex = 3;
            this.Quiz3Text.Text = "0";
            // 
            // Quiz4Text
            // 
            this.Quiz4Text.AutoSize = true;
            this.Quiz4Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz4Text.Location = new System.Drawing.Point(888, 289);
            this.Quiz4Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Quiz4Text.Name = "Quiz4Text";
            this.Quiz4Text.Size = new System.Drawing.Size(20, 24);
            this.Quiz4Text.TabIndex = 3;
            this.Quiz4Text.Text = "0";
            // 
            // QuizTotalText
            // 
            this.QuizTotalText.AutoSize = true;
            this.QuizTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizTotalText.Location = new System.Drawing.Point(967, 311);
            this.QuizTotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuizTotalText.Name = "QuizTotalText";
            this.QuizTotalText.Size = new System.Drawing.Size(20, 24);
            this.QuizTotalText.TabIndex = 3;
            this.QuizTotalText.Text = "0";
            // 
            // MidText
            // 
            this.MidText.AutoSize = true;
            this.MidText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidText.Location = new System.Drawing.Point(891, 334);
            this.MidText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MidText.Name = "MidText";
            this.MidText.Size = new System.Drawing.Size(20, 24);
            this.MidText.TabIndex = 3;
            this.MidText.Text = "0";
            // 
            // FinalText
            // 
            this.FinalText.AutoSize = true;
            this.FinalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalText.Location = new System.Drawing.Point(891, 356);
            this.FinalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinalText.Name = "FinalText";
            this.FinalText.Size = new System.Drawing.Size(20, 24);
            this.FinalText.TabIndex = 3;
            this.FinalText.Text = "0";
            // 
            // VivaText
            // 
            this.VivaText.AutoSize = true;
            this.VivaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VivaText.Location = new System.Drawing.Point(891, 378);
            this.VivaText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VivaText.Name = "VivaText";
            this.VivaText.Size = new System.Drawing.Size(20, 24);
            this.VivaText.TabIndex = 3;
            this.VivaText.Text = "0";
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalText.Location = new System.Drawing.Point(956, 400);
            this.TotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(20, 24);
            this.TotalText.TabIndex = 3;
            this.TotalText.Text = "0";
            // 
            // PercentageText
            // 
            this.PercentageText.AutoSize = true;
            this.PercentageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageText.Location = new System.Drawing.Point(901, 422);
            this.PercentageText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentageText.Name = "PercentageText";
            this.PercentageText.Size = new System.Drawing.Size(20, 24);
            this.PercentageText.TabIndex = 3;
            this.PercentageText.Text = "0";
            // 
            // GradeText
            // 
            this.GradeText.AutoSize = true;
            this.GradeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeText.Location = new System.Drawing.Point(856, 444);
            this.GradeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GradeText.Name = "GradeText";
            this.GradeText.Size = new System.Drawing.Size(22, 24);
            this.GradeText.TabIndex = 3;
            this.GradeText.Text = "F";
            // 
            // StudentNameText
            // 
            this.StudentNameText.AutoSize = true;
            this.StudentNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameText.Location = new System.Drawing.Point(720, 166);
            this.StudentNameText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentNameText.Name = "StudentNameText";
            this.StudentNameText.Size = new System.Drawing.Size(166, 29);
            this.StudentNameText.TabIndex = 3;
            this.StudentNameText.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "IUT Result Processing System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(844, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Made By : 200042156";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.VivaLabel);
            this.Controls.Add(this.FinalLabel);
            this.Controls.Add(this.MidLabel);
            this.Controls.Add(this.QuizTotalLabel);
            this.Controls.Add(this.Quiz4Label);
            this.Controls.Add(this.Quiz3Label);
            this.Controls.Add(this.Quiz2Label);
            this.Controls.Add(this.Quiz1Label);
            this.Controls.Add(this.QuizTotalText);
            this.Controls.Add(this.GradeText);
            this.Controls.Add(this.PercentageText);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.VivaText);
            this.Controls.Add(this.FinalText);
            this.Controls.Add(this.MidText);
            this.Controls.Add(this.Quiz4Text);
            this.Controls.Add(this.Quiz3Text);
            this.Controls.Add(this.Quiz2Text);
            this.Controls.Add(this.Quiz1Text);
            this.Controls.Add(this.AttendanceText);
            this.Controls.Add(this.StudentNameText);
            this.Controls.Add(this.AttendanceLabel);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "IUT Result Processing System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1; //StudentName
        private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.Label AttendanceLabel;
        private System.Windows.Forms.Label Quiz1Label;
        private System.Windows.Forms.Label Quiz2Label;
        private System.Windows.Forms.Label Quiz3Label;
        private System.Windows.Forms.Label Quiz4Label;
        private System.Windows.Forms.Label QuizTotalLabel;
        private System.Windows.Forms.Label MidLabel;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.Label VivaLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label AttendanceText;
        private System.Windows.Forms.Label Quiz1Text;
        private System.Windows.Forms.Label Quiz2Text;
        private System.Windows.Forms.Label Quiz3Text;
        private System.Windows.Forms.Label Quiz4Text;
        private System.Windows.Forms.Label QuizTotalText;
        private System.Windows.Forms.Label MidText;
        private System.Windows.Forms.Label FinalText;
        private System.Windows.Forms.Label VivaText;
        private System.Windows.Forms.Label TotalText;
        private System.Windows.Forms.Label PercentageText;
        private System.Windows.Forms.Label GradeText;
        private System.Windows.Forms.Label StudentNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

