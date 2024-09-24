using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLP_StudentPerformance
{
    public partial class Form1 : Form
    {
        //variable to hold question set size
        double numberOfQuestions = 0;

        //variables to track accumulation of answers
        int answeredWithoutPrompt = 0;
        int answeredWithPrompt = 0;
        int answered = 0;
        int unanswered = 0;


        //variables to track total percentages per category
        double percentageWithoutPrompt;
        double percentageWithPrompt = 0;
        double percentageAnswered = 0;
        double percentageUnanswered = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void answeredWithoutPromptButton_Click(object sender, EventArgs e)
        {
            answeredWithoutPrompt++;
            answered++;
            numberOfQuestions++;
            newProgressLabelTextArea.Text += "Question #" + numberOfQuestions.ToString() + ": " + "Without Prompt" + "\n";

        }

        private void answeredWithPromptButton_Click(object sender, EventArgs e)
        {
            answeredWithPrompt++;
            answered++;
            numberOfQuestions++;
            newProgressLabelTextArea.Text += "Question #" + numberOfQuestions.ToString() + ": " + "With Prompt" + "\n";
        }

        private void unansweredButton_Click(object sender, EventArgs e)
        {
            unanswered++;
            numberOfQuestions++;
            newProgressLabelTextArea.Text += "Question #" + numberOfQuestions.ToString() + ": " + "Unanswered" + "\n";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Clear user input
            answeredWithoutPrompt = 0;
            answeredWithPrompt = 0;
            answered = 0;
            unanswered = 0;
            numberOfQuestions = 0;

            //Clear calculations
            newProgressLabelTextArea.Text = " ";
            resultsLabelTextArea.Text = " ";
        }

        private void closeWithoutSavingButton_Click(object sender, EventArgs e)
        {
            //Close program
            this.Close();
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            //Save results 
            //******  NEED CODE HERE  ******

            //Close program
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (numberOfQuestions > 0)
            {
                percentageWithoutPrompt = answeredWithoutPrompt / numberOfQuestions * 100;
                percentageWithPrompt = answeredWithPrompt / numberOfQuestions * 100;
                percentageAnswered = answered / numberOfQuestions * 100;
                percentageUnanswered = unanswered / numberOfQuestions * 100;

                resultsLabelTextArea.Text += "Answered without prompt: " + "\n" + answeredWithoutPrompt + "/" + numberOfQuestions + " or " +
                    percentageWithoutPrompt.ToString("N1") + "%" + "\n" + "\n";
                resultsLabelTextArea.Text += "Answered with prompt: " + "\n" + answeredWithPrompt + "/" + numberOfQuestions + " or " +
                   percentageWithPrompt.ToString("N1") + "%" + "\n" + "\n" + "\n";
                resultsLabelTextArea.Text += "Answered: " + "\n" + answered + "/" + numberOfQuestions + " or " +
                   percentageAnswered.ToString("N1") + "%" + "\n" + "\n";
                resultsLabelTextArea.Text += "Unanswered: " + "\n" + unanswered + "/" + numberOfQuestions + " or " +
                   percentageUnanswered.ToString("N1") + "%" + "\n";
            } else
            {
                MessageBox.Show("Please record at least one response to view results.");
            }
            

        }
    }
}
