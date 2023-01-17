using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleQuiz
{
    public partial class Form1 : Form
    {
        List<Quiz> Quizes = new List<Quiz>();
        int QuizIndex = 0; // 現在のクイズ

        public Form1()
        {
            InitializeComponent();

            InitQuizes();

            if (Quizes.Count > 0)
                ShowQuiz(0);

            SetClickEventHandlers();

            EnableButtons();
        }

        void InitQuizes()
        {
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
        }

        void ShowQuiz(int i)
        {
            Quiz quiz = Quizes[i];

            LabelsUnVisible();
            labelQuestion.Text = quiz.Question;

            if (quiz.Choices.Length >= 1 && quiz.Choices[0] != "")
            {
                labelChoices1.Text = quiz.Choices[0];
                labelChoices1.Visible = true;
            }
            if (quiz.Choices.Length >= 2 && quiz.Choices[1] != "")
            {
                labelChoices2.Text = quiz.Choices[1];
                labelChoices2.Visible = true;
            }
            if (quiz.Choices.Length >= 3 && quiz.Choices[2] != "")
            {
                labelChoices3.Text = quiz.Choices[2];
                labelChoices3.Visible = true;
            }
            if (quiz.Choices.Length >= 4 && quiz.Choices[3] != "")
            {
                labelChoices4.Text = quiz.Choices[3];
                labelChoices4.Visible = true;
            }
        }

        void LabelsUnVisible()
        {
            labelChoices1.Visible = false;
            labelChoices2.Visible = false;
            labelChoices3.Visible = false;
            labelChoices4.Visible = false;
        }

        void SetClickEventHandlers()
        {
            labelChoices1.Click += LabelChoices_Click;
            labelChoices2.Click += LabelChoices_Click;
            labelChoices3.Click += LabelChoices_Click;
            labelChoices4.Click += LabelChoices_Click;
        }

        private void LabelChoices_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            labelResult.ForeColor = Color.White;
            if (Judg(QuizIndex, label.Text))
            {
                labelResult.BackColor = Color.Red;
                labelResult.Text = "正解！";
            }
            else
            {
                labelResult.BackColor = Color.Black;
                labelResult.Text = "残念！";
            }

            labelResult.Visible = true;
        }

        bool Judg(int i, string choice)
        {
            if (Quizes[i].Answer == choice)
                return true;
            else
                return false;
        }

        void EnableButtons()
        {
            if (QuizIndex > 0)
                buttonPrev.Enabled = true;
            else
                buttonPrev.Enabled = false;

            if (QuizIndex < Quizes.Count - 1)
                buttonNext.Enabled = true;
            else
                buttonNext.Enabled = false;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (0 < QuizIndex)
            {
                QuizIndex--;
                ShowQuiz(QuizIndex);
            }

            EnableButtons();

            // 前の問題が表示されるので、これまで表示されていた問題の結果は非表示にする
            labelResult.Visible = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (Quizes.Count > QuizIndex + 1)
            {
                QuizIndex++;
                ShowQuiz(QuizIndex);
            }
            EnableButtons();

            // 次の問題が表示されるので、これまで表示されていた問題の結果は非表示にする
            labelResult.Visible = false;
        }
    }
}
