﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100to1
{
    public partial class ViewForm : Form
    {
        public ArrayList teamsMistakes = new ArrayList(); //Костыль, но ничего лучше я не придумал)
        public ArrayList AnswersPB = new ArrayList();

        public ViewForm()
        {
            InitializeComponent();
            mistakesInit();
            answersInit();
            
        }

        public void mistakesInit()
        {
            teamsMistakes.Add(teamOneMistakeOneTrue);
            teamsMistakes.Add(teamOneMistakeTwoTrue);
            teamsMistakes.Add(teamOneMistakeThreeTrue);

            teamsMistakes.Add(teamTwoMistakeOneTrue);
            teamsMistakes.Add(teamTwoMistakeTwoTrue);
            teamsMistakes.Add(teamTwoMistakeThreeTrue);

        }

        public void answersInit()
        {
            AnswersPB.Add(answerOnePB);
            AnswersPB.Add(answerTwoPB);
            AnswersPB.Add(answerThreePB);
            AnswersPB.Add(answerFourPB);
            AnswersPB.Add(answerFivePB);
            AnswersPB.Add(answerSixPB);
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {

        }

        private void teamOneMistakeTwoTrue_Click(object sender, EventArgs e)
        {

        }

        private void teamOneMistakeOneTrue_Click(object sender, EventArgs e)
        {

        }

        private void teamOneMistakeThree_Click(object sender, EventArgs e)
        {

        }

        private void teamOneMistakeTwo_Click(object sender, EventArgs e)
        {

        }

        private void teamOneMistakeOne_Click(object sender, EventArgs e)
        {

        }

        private void teamTwoMistakeThreeTrue_Click(object sender, EventArgs e)
        {

        }

        private void teamOneMistakeThreeTrue_Click(object sender, EventArgs e)
        {

        }

        private void teamTwoMistakeTwoTrue_Click(object sender, EventArgs e)
        {

        }

        private void teamTwoMistakeOneTrue_Click(object sender, EventArgs e)
        {

        }

        private void teamTwoMistakeThree_Click(object sender, EventArgs e)
        {

        }

        private void teamTwoMistakeTwo_Click(object sender, EventArgs e)
        {

        }

        private void teamTwoMistakeOne_Click(object sender, EventArgs e)
        {

        }
    }
}
