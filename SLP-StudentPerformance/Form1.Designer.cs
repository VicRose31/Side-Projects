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
            this.label1 = new System.Windows.Forms.Label();
            this.resultsLabelTextArea = new System.Windows.Forms.Label();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressLabelTextArea = new System.Windows.Forms.Label();
            this.newProgressLabelTextArea = new System.Windows.Forms.Label();
            this.progressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // answeredWithoutPromptButton
            // 
            this.answeredWithoutPromptButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.answeredWithoutPromptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.answeredWithoutPromptButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.answeredWithoutPromptButton.Location = new System.Drawing.Point(26, 75);
            this.answeredWithoutPromptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.answeredWithoutPromptButton.Name = "answeredWithoutPromptButton";
            this.answeredWithoutPromptButton.Size = new System.Drawing.Size(244, 114);
            this.answeredWithoutPromptButton.TabIndex = 0;
            this.answeredWithoutPromptButton.Text = "+";
            this.answeredWithoutPromptButton.UseCompatibleTextRendering = true;
            this.answeredWithoutPromptButton.UseVisualStyleBackColor = false;
            this.answeredWithoutPromptButton.Click += new System.EventHandler(this.answeredWithoutPromptButton_Click);
            // 
            // answeredWithPromptButton
            // 
            this.answeredWithPromptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.answeredWithPromptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.answeredWithPromptButton.Location = new System.Drawing.Point(26, 230);
            this.answeredWithPromptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.answeredWithPromptButton.Name = "answeredWithPromptButton";
            this.answeredWithPromptButton.Size = new System.Drawing.Size(244, 114);
            this.answeredWithPromptButton.TabIndex = 1;
            this.answeredWithPromptButton.Text = "Prompted";
            this.answeredWithPromptButton.UseVisualStyleBackColor = false;
            this.answeredWithPromptButton.Click += new System.EventHandler(this.answeredWithPromptButton_Click);
            // 
            // unansweredButton
            // 
            this.unansweredButton.BackColor = System.Drawing.Color.Tomato;
            this.unansweredButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.unansweredButton.Location = new System.Drawing.Point(26, 384);
            this.unansweredButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unansweredButton.Name = "unansweredButton";
            this.unansweredButton.Size = new System.Drawing.Size(244, 114);
            this.unansweredButton.TabIndex = 2;
            this.unansweredButton.Text = "-";
            this.unansweredButton.UseVisualStyleBackColor = false;
            this.unansweredButton.Click += new System.EventHandler(this.unansweredButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resetButton.Location = new System.Drawing.Point(62, 529);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(172, 62);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calculateButton.Location = new System.Drawing.Point(62, 600);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(172, 62);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveAndCloseButton.Location = new System.Drawing.Point(640, 529);
            this.saveAndCloseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(172, 62);
            this.saveAndCloseButton.TabIndex = 5;
            this.saveAndCloseButton.Text = "Save and Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // closeWithoutSavingButton
            // 
            this.closeWithoutSavingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.closeWithoutSavingButton.Location = new System.Drawing.Point(640, 600);
            this.closeWithoutSavingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeWithoutSavingButton.Name = "closeWithoutSavingButton";
            this.closeWithoutSavingButton.Size = new System.Drawing.Size(172, 62);
            this.closeWithoutSavingButton.TabIndex = 6;
            this.closeWithoutSavingButton.Text = "Close";
            this.closeWithoutSavingButton.UseVisualStyleBackColor = true;
            this.closeWithoutSavingButton.Click += new System.EventHandler(this.closeWithoutSavingButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressLabel.Location = new System.Drawing.Point(288, 35);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(117, 29);
            this.progressLabel.TabIndex = 7;
            this.progressLabel.Text = "Progress:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultsLabel.Location = new System.Drawing.Point(639, 35);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(99, 29);
            this.resultsLabel.TabIndex = 8;
            this.resultsLabel.Text = "Results:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 11;
            // 
            // resultsLabelTextArea
            // 
            this.resultsLabelTextArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultsLabelTextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resultsLabelTextArea.Location = new System.Drawing.Point(640, 75);
            this.resultsLabelTextArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabelTextArea.Name = "resultsLabelTextArea";
            this.resultsLabelTextArea.Size = new System.Drawing.Size(330, 423);
            this.resultsLabelTextArea.TabIndex = 12;
            // 
            // progressPanel
            // 
            this.progressPanel.AutoScroll = true;
            this.progressPanel.Controls.Add(this.label2);
            this.progressPanel.Controls.Add(this.progressLabelTextArea);
            this.progressPanel.Location = new System.Drawing.Point(293, 67);
            this.progressPanel.MaximumSize = new System.Drawing.Size(310, 0);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(310, 0);
            this.progressPanel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MaximumSize = new System.Drawing.Size(305, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 0);
            this.label2.TabIndex = 13;
            // 
            // progressLabelTextArea
            // 
            this.progressLabelTextArea.AutoSize = true;
            this.progressLabelTextArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressLabelTextArea.CausesValidation = false;
            this.progressLabelTextArea.Location = new System.Drawing.Point(86, 136);
            this.progressLabelTextArea.MaximumSize = new System.Drawing.Size(30, 0);
            this.progressLabelTextArea.Name = "progressLabelTextArea";
            this.progressLabelTextArea.Size = new System.Drawing.Size(0, 20);
            this.progressLabelTextArea.TabIndex = 0;
            // 
            // newProgressLabelTextArea
            // 
            this.newProgressLabelTextArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newProgressLabelTextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newProgressLabelTextArea.Location = new System.Drawing.Point(288, 75);
            this.newProgressLabelTextArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newProgressLabelTextArea.Name = "newProgressLabelTextArea";
            this.newProgressLabelTextArea.Size = new System.Drawing.Size(330, 423);
            this.newProgressLabelTextArea.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 759);
            this.Controls.Add(this.newProgressLabelTextArea);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.resultsLabelTextArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.closeWithoutSavingButton);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.unansweredButton);
            this.Controls.Add(this.answeredWithPromptButton);
            this.Controls.Add(this.answeredWithoutPromptButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultsLabelTextArea;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Label progressLabelTextArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newProgressLabelTextArea;
    }
}

