namespace Hangman
{
    partial class frm_Hangman
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_Keyboard = new System.Windows.Forms.GroupBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.gb_Text = new System.Windows.Forms.GroupBox();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_F = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_Backspace = new System.Windows.Forms.Button();
            this.lbl_P1 = new System.Windows.Forms.Label();
            this.lbl_P2 = new System.Windows.Forms.Label();
            this.lbl_P3 = new System.Windows.Forms.Label();
            this.lbl_P4 = new System.Windows.Forms.Label();
            this.lbl_P5 = new System.Windows.Forms.Label();
            this.lbl_P6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Keyboard.SuspendLayout();
            this.gb_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hangman.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(824, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gb_Keyboard
            // 
            this.gb_Keyboard.Controls.Add(this.btn_Backspace);
            this.gb_Keyboard.Controls.Add(this.btn_B);
            this.gb_Keyboard.Controls.Add(this.btn_C);
            this.gb_Keyboard.Controls.Add(this.btn_E);
            this.gb_Keyboard.Controls.Add(this.btn_F);
            this.gb_Keyboard.Controls.Add(this.btn_D);
            this.gb_Keyboard.Controls.Add(this.btn_A);
            this.gb_Keyboard.Location = new System.Drawing.Point(74, 444);
            this.gb_Keyboard.Name = "gb_Keyboard";
            this.gb_Keyboard.Size = new System.Drawing.Size(713, 154);
            this.gb_Keyboard.TabIndex = 1;
            this.gb_Keyboard.TabStop = false;
            this.gb_Keyboard.Text = "Keyboard";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(372, 61);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(338, 79);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Hangman";
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Location = new System.Drawing.Point(324, 157);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(474, 25);
            this.lbl_Subtitle.TabIndex = 3;
            this.lbl_Subtitle.Text = "Created by Omer Ben-Yosrc and Daniel naaman";
            // 
            // gb_Text
            // 
            this.gb_Text.Controls.Add(this.lbl_P6);
            this.gb_Text.Controls.Add(this.lbl_P5);
            this.gb_Text.Controls.Add(this.lbl_P4);
            this.gb_Text.Controls.Add(this.lbl_P3);
            this.gb_Text.Controls.Add(this.lbl_P2);
            this.gb_Text.Controls.Add(this.lbl_P1);
            this.gb_Text.Location = new System.Drawing.Point(74, 248);
            this.gb_Text.Name = "gb_Text";
            this.gb_Text.Size = new System.Drawing.Size(713, 150);
            this.gb_Text.TabIndex = 2;
            this.gb_Text.TabStop = false;
            this.gb_Text.Text = "Text";
            // 
            // btn_A
            // 
            this.btn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A.Location = new System.Drawing.Point(25, 45);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(87, 78);
            this.btn_A.TabIndex = 0;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_Letter_Click);
            // 
            // btn_D
            // 
            this.btn_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D.Location = new System.Drawing.Point(307, 45);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(87, 78);
            this.btn_D.TabIndex = 1;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_Letter_Click);
            // 
            // btn_F
            // 
            this.btn_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F.Location = new System.Drawing.Point(493, 45);
            this.btn_F.Name = "btn_F";
            this.btn_F.Size = new System.Drawing.Size(87, 78);
            this.btn_F.TabIndex = 2;
            this.btn_F.Text = "F";
            this.btn_F.UseVisualStyleBackColor = true;
            this.btn_F.Click += new System.EventHandler(this.btn_Letter_Click);
            // 
            // btn_E
            // 
            this.btn_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_E.Location = new System.Drawing.Point(400, 45);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(87, 78);
            this.btn_E.TabIndex = 3;
            this.btn_E.Text = "E";
            this.btn_E.UseVisualStyleBackColor = true;
            this.btn_E.Click += new System.EventHandler(this.btn_Letter_Click);
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.Location = new System.Drawing.Point(214, 45);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(87, 78);
            this.btn_C.TabIndex = 4;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_Letter_Click);
            // 
            // btn_B
            // 
            this.btn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B.Location = new System.Drawing.Point(121, 45);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(87, 78);
            this.btn_B.TabIndex = 5;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_Letter_Click);
            // 
            // btn_Backspace
            // 
            this.btn_Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backspace.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Backspace.Location = new System.Drawing.Point(589, 45);
            this.btn_Backspace.Name = "btn_Backspace";
            this.btn_Backspace.Size = new System.Drawing.Size(87, 78);
            this.btn_Backspace.TabIndex = 6;
            this.btn_Backspace.Text = "X";
            this.btn_Backspace.UseVisualStyleBackColor = true;
            // 
            // lbl_P1
            // 
            this.lbl_P1.AutoSize = true;
            this.lbl_P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P1.Location = new System.Drawing.Point(25, 54);
            this.lbl_P1.Name = "lbl_P1";
            this.lbl_P1.Size = new System.Drawing.Size(57, 61);
            this.lbl_P1.TabIndex = 4;
            this.lbl_P1.Text = "_";
            // 
            // lbl_P2
            // 
            this.lbl_P2.AutoSize = true;
            this.lbl_P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P2.Location = new System.Drawing.Point(88, 54);
            this.lbl_P2.Name = "lbl_P2";
            this.lbl_P2.Size = new System.Drawing.Size(57, 61);
            this.lbl_P2.TabIndex = 5;
            this.lbl_P2.Text = "_";
            // 
            // lbl_P3
            // 
            this.lbl_P3.AutoSize = true;
            this.lbl_P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P3.Location = new System.Drawing.Point(151, 54);
            this.lbl_P3.Name = "lbl_P3";
            this.lbl_P3.Size = new System.Drawing.Size(57, 61);
            this.lbl_P3.TabIndex = 6;
            this.lbl_P3.Text = "_";
            // 
            // lbl_P4
            // 
            this.lbl_P4.AutoSize = true;
            this.lbl_P4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P4.Location = new System.Drawing.Point(214, 54);
            this.lbl_P4.Name = "lbl_P4";
            this.lbl_P4.Size = new System.Drawing.Size(57, 61);
            this.lbl_P4.TabIndex = 7;
            this.lbl_P4.Text = "_";
            // 
            // lbl_P5
            // 
            this.lbl_P5.AutoSize = true;
            this.lbl_P5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P5.Location = new System.Drawing.Point(277, 54);
            this.lbl_P5.Name = "lbl_P5";
            this.lbl_P5.Size = new System.Drawing.Size(57, 61);
            this.lbl_P5.TabIndex = 8;
            this.lbl_P5.Text = "_";
            // 
            // lbl_P6
            // 
            this.lbl_P6.AutoSize = true;
            this.lbl_P6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P6.Location = new System.Drawing.Point(337, 54);
            this.lbl_P6.Name = "lbl_P6";
            this.lbl_P6.Size = new System.Drawing.Size(57, 61);
            this.lbl_P6.TabIndex = 9;
            this.lbl_P6.Text = "_";
            // 
            // frm_Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 750);
            this.Controls.Add(this.gb_Text);
            this.Controls.Add(this.lbl_Subtitle);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.gb_Keyboard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Hangman";
            this.Text = "Hangman (Omer Ben-Yosef & Daniel Naaman)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Keyboard.ResumeLayout(false);
            this.gb_Text.ResumeLayout(false);
            this.gb_Text.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_Keyboard;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Backspace;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.GroupBox gb_Text;
        private System.Windows.Forms.Label lbl_P6;
        private System.Windows.Forms.Label lbl_P5;
        private System.Windows.Forms.Label lbl_P4;
        private System.Windows.Forms.Label lbl_P3;
        private System.Windows.Forms.Label lbl_P2;
        private System.Windows.Forms.Label lbl_P1;
    }
}

