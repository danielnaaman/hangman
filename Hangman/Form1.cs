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

        public frm_Hangman()
        {
            InitializeComponent();
        }

        private void btn_Letter_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            switch (m_CurrentLabelLetter)
            {
                case 1:
                    {
                        lbl_P1.Text = buttonText;
                        break;
                    }
                case 2:
                    {
                        lbl_P2.Text = buttonText;
                        break;
                    }
                case 3:
                    {
                        lbl_P3.Text = buttonText;
                        break;
                    }
                case 4:
                    {
                        lbl_P4.Text = buttonText;
                        break;
                    }
                case 5:
                    {
                        lbl_P5.Text = buttonText;
                        break;
                    }
                case 6:
                    {
                        lbl_P6.Text = buttonText;
                        break;
                    }
            }
            m_CurrentLabelLetter++;
        }
    }
}
