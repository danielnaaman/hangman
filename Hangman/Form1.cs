using Hangman.Properties;
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
        private bool m_IsFirstPlayer = true;
        private int m_CurrentLabelLetter = 1;
        private string m_WordToGuess;
        private int m_CountError = 0;

        private Image[]  m_Images = new Image[6]; // ????

        public void SetImagesArray()
        {
            m_Images[0] = Resources.yo1;
            m_Images[1] = Resources.yo2;
            m_Images[2] = Resources.yo3;
            m_Images[3] = Resources.yo4;
            m_Images[4] = Resources.yo5;
            m_Images[5] = Resources.yo6;
        }

        public frm_Hangman()
        {
            InitializeComponent();
            SetImagesArray();
        }

        private void btn_Letter_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;

            if (m_IsFirstPlayer)
            {
                gb_Text.Controls["lbl_P" + m_CurrentLabelLetter].Text = buttonText;
                m_CurrentLabelLetter++;
            }

            else
            {
                if (m_WordToGuess.Contains(buttonText))
                {
                    for (int i = 0; i < m_WordToGuess.Length; i++)
                    {
                        if (m_WordToGuess[i].ToString() == buttonText)
                            gb_Text.Controls["lbl_P" + (i + 1)].Text = buttonText;
                    }
                }

                else
                {
                    m_CountError++;
                    pictureBox1.Image = m_Images[m_CountError - 1];
                }
                (sender as Button).Enabled = false;
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
            m_IsFirstPlayer = false;
        }
    }
}
