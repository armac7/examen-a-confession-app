namespace Examen
{
    partial class HelpForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            searchbox = new TextBox();
            searchButton = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(339, 37);
            button1.TabIndex = 0;
            button1.Text = "What is Confession?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += getAnswer;
            // 
            // button2
            // 
            button2.Location = new Point(12, 64);
            button2.Name = "button2";
            button2.Size = new Size(339, 37);
            button2.TabIndex = 1;
            button2.Text = "Why do I need to confess my sins?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += getAnswer;
            // 
            // button3
            // 
            button3.Location = new Point(12, 107);
            button3.Name = "button3";
            button3.Size = new Size(339, 37);
            button3.TabIndex = 2;
            button3.Text = "What is a Mortal Sin?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += getAnswer;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(12, 150);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(209, 23);
            searchbox.TabIndex = 3;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(227, 150);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(124, 23);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(146, 193);
            button5.Name = "button5";
            button5.Size = new Size(75, 46);
            button5.TabIndex = 5;
            button5.Text = "OK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += okButton_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 251);
            Controls.Add(button5);
            Controls.Add(searchButton);
            Controls.Add(searchbox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(380, 290);
            MinimumSize = new Size(380, 290);
            Name = "HelpForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Examen - Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox searchbox;
        private Button searchButton;
        private Button button5;
    }
}