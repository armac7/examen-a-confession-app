namespace Examen
{
    partial class ExamenController
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            confessButton = new Button();
            infoButton = new Button();
            prayersButton = new Button();
            quitButton = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MOON GET!", 30F, FontStyle.Bold);
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(214, 70);
            label1.TabIndex = 0;
            label1.Text = "Examen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MOON GET!", 15F);
            label2.Location = new Point(30, 89);
            label2.Name = "label2";
            label2.Size = new Size(233, 34);
            label2.TabIndex = 1;
            label2.Text = "A Confession App";
            // 
            // confessButton
            // 
            confessButton.Location = new Point(30, 249);
            confessButton.Name = "confessButton";
            confessButton.Size = new Size(224, 58);
            confessButton.TabIndex = 2;
            confessButton.Text = "Let's Confess";
            confessButton.UseVisualStyleBackColor = true;
            confessButton.Click += confessButton_Click_1;
            // 
            // infoButton
            // 
            infoButton.Location = new Point(30, 377);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(105, 47);
            infoButton.TabIndex = 3;
            infoButton.Text = "More Information";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
            // 
            // prayersButton
            // 
            prayersButton.Location = new Point(30, 313);
            prayersButton.Name = "prayersButton";
            prayersButton.Size = new Size(224, 58);
            prayersButton.TabIndex = 4;
            prayersButton.Text = "Prayers";
            prayersButton.UseVisualStyleBackColor = true;
            prayersButton.Click += prayersButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(149, 377);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(105, 47);
            quitButton.TabIndex = 5;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // logo
            // 
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.ImageLocation = "data/logo.png";
            logo.Location = new Point(30, 12);
            logo.Name = "logo";
            logo.Size = new Size(224, 225);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 6;
            logo.TabStop = false;
            // 
            // ExamenController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(283, 438);
            Controls.Add(logo);
            Controls.Add(quitButton);
            Controls.Add(prayersButton);
            Controls.Add(infoButton);
            Controls.Add(confessButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ExamenController";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Examen";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button confessButton;
        private Button infoButton;
        private Button prayersButton;
        private Button quitButton;
        private PictureBox logo;
    }
}
