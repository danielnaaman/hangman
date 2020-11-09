using Hangman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private int m_CountCorrect = 0;

        private Image[]  m_Images = new Image[6];

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
                        if (m_WordToGuess[i].ToString() == buttonText) { 
                            gb_Text.Controls["lbl_P" + (i + 1)].Text = buttonText;
                            m_CountCorrect += 1;
                            if (m_CountCorrect == (m_WordToGuess.Length - RemoveUnderscores(m_WordToGuess))) // RONI LOOK THIS COOL :)
                            {
                                this.Hide();
                                Form f2 = new Form3();
                                f2.Show();
                            }
                        }
                    }
                }

                else
                {
                    m_CountError++;
                    pictureBox1.Image = m_Images[m_CountError - 1];
                    if (m_CountError >= m_Images.Length)
                    {
                        this.Hide();
                        Form f1 = new Form2();
                        f1.Show();

                    }
                }
                (sender as Button).Enabled = false;
            }
        }

        private int RemoveUnderscores (string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '_')
                {
                    count++;
                }
            }
            return count;
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
            for (int i = 1; i <= 6; i++)
            {
                curLabel = gb_Text.Controls["lbl_P" + i] as Label;
                m_WordToGuess += curLabel.Text;
                curLabel.Text = "_";
            }

            btn_Backspace.Visible = false;
            btn_Submit.Visible = false;

            m_CurrentLabelLetter = 1;
            m_IsFirstPlayer = false;
        }
    }
}
