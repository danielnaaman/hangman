using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frm_Hangman : Form
    {
        private int m_CurrentLabelLetter = 1;
        private string m_WordToGuess;

        public frm_Hangman()
        {
            InitializeComponent();
        }

        private void btn_Letter_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;

            if (m_CurrentLabelLetter <= 6)
            {
                gb_Text.Controls["lbl_P" + m_CurrentLabelLetter].Text = buttonText;
                m_CurrentLabelLetter++;
            }
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if (m_CurrentLabelLetter > 1) { 
                gb_Text.Controls["lbl_P" + (m_CurrentLabelLetter - 1)].Text = "_";
                m_CurrentLabelLetter--;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Label curLabel;
            for (int i = 1; i <= 5; i++)
            {
                curLabel = gb_Text.Controls["lbl_P" + i] as Label;
                m_WordToGuess += curLabel.Text;
                curLabel.Text = "_";
            }

            btn_Backspace.Visible = false;
            btn_Submit.Visible = false;

            if (m_CurrentLabelLetter == 6)
                btn_Submit.Enabled = true;

            btn_Backspace.Enabled = false;

            m_CurrentLabelLetter = 1;
        }
    }
}
