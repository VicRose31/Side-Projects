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
        //variable to hold question set size         //where to place the three variable sections????
        int numberOfQuestions = 0;

        //variables to track accumulation of answers
        int answeredWithoutPrompt = 0;
        int answeredWithPrompt = 0;
        //int answered = answeredWithoutPrompt + answeredWithPrompt;
        int unanswered = 0;

        //variables to track total percentages per category
        decimal percentageWithoutPrompt = 0;
        decimal percentageWithPrompt = 0;
        decimal percentageAnswered = 0;
        decimal percentageUnanswered = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //INPUT
            //convert user input to numberic data and store in variable          //possibly remove user input entirely
            bool numberOfQuestionsBool;
            numberOfQuestionsBool = Int32.TryParse(numberOfQuestionsTextbox.Text, out numberOfQuestions);
            if (!numberOfQuestionsBool)
            {
                MessageBox.Show("Error: Please enter positive, numeric data in the textbox.");
                return;
            }

        }

        private void answeredWithoutPromptButton_Click(object sender, EventArgs e)
        {
            answeredWithoutPrompt++;
        }

        private void answeredWithPromptButton_Click(object sender, EventArgs e)
        {
            answeredWithPrompt++;
        }

        private void unansweredButton_Click(object sender, EventArgs e)
        {
            unanswered++;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Clear user input
            answeredWithoutPrompt = 0;
            answeredWithPrompt = 0;
            unanswered = 0;

            //Clear calculations
            progressLabelTextArea.Text = " ";
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

        }
    }
}
