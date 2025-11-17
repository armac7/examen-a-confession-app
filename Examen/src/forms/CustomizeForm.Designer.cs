namespace Examen
{
    partial class CustomizeForm
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
            label1 = new Label();
            prayerCB = new CheckBox();
            guideCB = new CheckBox();
            confessButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 15);
            label1.TabIndex = 0;
            label1.Text = "Would you like to add anything to your confession?";
            // 
            // prayerCB
            // 
            prayerCB.AutoSize = true;
            prayerCB.Location = new Point(12, 37);
            prayerCB.Name = "prayerCB";
            prayerCB.Size = new Size(59, 19);
            prayerCB.TabIndex = 1;
            prayerCB.Text = "Prayer";
            prayerCB.UseVisualStyleBackColor = true;
            prayerCB.CheckedChanged += prayerCB_CheckedChanged;
            // 
            // guideCB
            // 
            guideCB.AutoSize = true;
            guideCB.Location = new Point(12, 62);
            guideCB.Name = "guideCB";
            guideCB.Size = new Size(119, 19);
            guideCB.TabIndex = 2;
            guideCB.Text = "Confession Guide";
            guideCB.UseVisualStyleBackColor = true;
            guideCB.CheckedChanged += guideCB_CheckedChanged;
            // 
            // confessButton
            // 
            confessButton.Location = new Point(12, 87);
            confessButton.Name = "confessButton";
            confessButton.Size = new Size(115, 34);
            confessButton.TabIndex = 3;
            confessButton.Text = "Confess";
            confessButton.UseVisualStyleBackColor = true;
            confessButton.Click += confessButton_Click;
            // 
            // CustomizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 126);
            Controls.Add(confessButton);
            Controls.Add(guideCB);
            Controls.Add(prayerCB);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(345, 165);
            MinimumSize = new Size(345, 165);
            Name = "CustomizeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customize Confession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox prayerCB;
        private CheckBox guideCB;
        private Button confessButton;
    }
}