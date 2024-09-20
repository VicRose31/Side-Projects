namespace SLP_StudentPerformance
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
            this.answeredWithoutPromptButton = new System.Windows.Forms.Button();
            this.answeredWithPromptButton = new System.Windows.Forms.Button();
            this.unansweredButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.closeWithoutSavingButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.numberOfQuestionsInSetLabel = new System.Windows.Forms.Label();
            this.numberOfQuestionsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsLabelTextArea = new System.Windows.Forms.Label();
            this.progressLabelTextArea = new System.Windows.Forms.Label();
            this.unknownSizeCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // answeredWithoutPromptButton
            // 
            this.answeredWithoutPromptButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.answeredWithoutPromptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.answeredWithoutPromptButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.answeredWithoutPromptButton.Location = new System.Drawing.Point(77, 80);
            this.answeredWithoutPromptButton.Name = "answeredWithoutPromptButton";
            this.answeredWithoutPromptButton.Size = new System.Drawing.Size(163, 74);
            this.answeredWithoutPromptButton.TabIndex = 0;
            this.answeredWithoutPromptButton.Text = "Answered Without Prompt";
            this.answeredWithoutPromptButton.UseVisualStyleBackColor = false;
            this.answeredWithoutPromptButton.Click += new System.EventHandler(this.answeredWithoutPromptButton_Click);
            // 
            // answeredWithPromptButton
            // 
            this.answeredWithPromptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.answeredWithPromptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.answeredWithPromptButton.Location = new System.Drawing.Point(77, 181);
            this.answeredWithPromptButton.Name = "answeredWithPromptButton";
            this.answeredWithPromptButton.Size = new System.Drawing.Size(163, 74);
            this.answeredWithPromptButton.TabIndex = 1;
            this.answeredWithPromptButton.Text = "Answered With Prompt";
            this.answeredWithPromptButton.UseVisualStyleBackColor = false;
            this.answeredWithPromptButton.Click += new System.EventHandler(this.answeredWithPromptButton_Click);
            // 
            // unansweredButton
            // 
            this.unansweredButton.BackColor = System.Drawing.Color.Tomato;
            this.unansweredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unansweredButton.Location = new System.Drawing.Point(77, 281);
            this.unansweredButton.Name = "unansweredButton";
            this.unansweredButton.Size = new System.Drawing.Size(163, 74);
            this.unansweredButton.TabIndex = 2;
            this.unansweredButton.Text = "Unanswered";
            this.unansweredButton.UseVisualStyleBackColor = false;
            this.unansweredButton.Click += new System.EventHandler(this.unansweredButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resetButton.Location = new System.Drawing.Point(101, 375);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(115, 40);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calculateButton.Location = new System.Drawing.Point(101, 421);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(115, 40);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveAndCloseButton.Location = new System.Drawing.Point(487, 375);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(115, 40);
            this.saveAndCloseButton.TabIndex = 5;
            this.saveAndCloseButton.Text = "Save and Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // closeWithoutSavingButton
            // 
            this.closeWithoutSavingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.closeWithoutSavingButton.Location = new System.Drawing.Point(487, 421);
            this.closeWithoutSavingButton.Name = "closeWithoutSavingButton";
            this.closeWithoutSavingButton.Size = new System.Drawing.Size(115, 40);
            this.closeWithoutSavingButton.TabIndex = 6;
            this.closeWithoutSavingButton.Text = "Close";
            this.closeWithoutSavingButton.UseVisualStyleBackColor = true;
            this.closeWithoutSavingButton.Click += new System.EventHandler(this.closeWithoutSavingButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressLabel.Location = new System.Drawing.Point(269, 54);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(76, 20);
            this.progressLabel.TabIndex = 7;
            this.progressLabel.Text = "Progress:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultsLabel.Location = new System.Drawing.Point(486, 54);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(67, 20);
            this.resultsLabel.TabIndex = 8;
            this.resultsLabel.Text = "Results:";
            // 
            // numberOfQuestionsInSetLabel
            // 
            this.numberOfQuestionsInSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numberOfQuestionsInSetLabel.Location = new System.Drawing.Point(74, 19);
            this.numberOfQuestionsInSetLabel.Name = "numberOfQuestionsInSetLabel";
            this.numberOfQuestionsInSetLabel.Size = new System.Drawing.Size(369, 23);
            this.numberOfQuestionsInSetLabel.TabIndex = 9;
            this.numberOfQuestionsInSetLabel.Text = "Please enter the number of questions in the set:";
            // 
            // numberOfQuestionsTextbox
            // 
            this.numberOfQuestionsTextbox.Location = new System.Drawing.Point(425, 19);
            this.numberOfQuestionsTextbox.Name = "numberOfQuestionsTextbox";
            this.numberOfQuestionsTextbox.Size = new System.Drawing.Size(39, 20);
            this.numberOfQuestionsTextbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // resultsLabelTextArea
            // 
            this.resultsLabelTextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resultsLabelTextArea.Location = new System.Drawing.Point(487, 80);
            this.resultsLabelTextArea.Name = "resultsLabelTextArea";
            this.resultsLabelTextArea.Size = new System.Drawing.Size(194, 275);
            this.resultsLabelTextArea.TabIndex = 12;
            // 
            // progressLabelTextArea
            // 
            this.progressLabelTextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.progressLabelTextArea.Location = new System.Drawing.Point(270, 80);
            this.progressLabelTextArea.Name = "progressLabelTextArea";
            this.progressLabelTextArea.Size = new System.Drawing.Size(194, 275);
            this.progressLabelTextArea.TabIndex = 13;
            // 
            // unknownSizeCheckbox
            // 
            this.unknownSizeCheckbox.BackColor = System.Drawing.SystemColors.Control;
            this.unknownSizeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.unknownSizeCheckbox.Location = new System.Drawing.Point(525, 16);
            this.unknownSizeCheckbox.Name = "unknownSizeCheckbox";
            this.unknownSizeCheckbox.Size = new System.Drawing.Size(175, 30);
            this.unknownSizeCheckbox.TabIndex = 14;
            this.unknownSizeCheckbox.Text = "Set size unknown";
            this.unknownSizeCheckbox.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.unknownSizeCheckbox);
            this.Controls.Add(this.progressLabelTextArea);
            this.Controls.Add(this.resultsLabelTextArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfQuestionsTextbox);
            this.Controls.Add(this.numberOfQuestionsInSetLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.closeWithoutSavingButton);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.unansweredButton);
            this.Controls.Add(this.answeredWithPromptButton);
            this.Controls.Add(this.answeredWithoutPromptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answeredWithoutPromptButton;
        private System.Windows.Forms.Button answeredWithPromptButton;
        private System.Windows.Forms.Button unansweredButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Button closeWithoutSavingButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label numberOfQuestionsInSetLabel;
        private System.Windows.Forms.TextBox numberOfQuestionsTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultsLabelTextArea;
        private System.Windows.Forms.Label progressLabelTextArea;
        private System.Windows.Forms.CheckBox unknownSizeCheckbox;
    }
}

