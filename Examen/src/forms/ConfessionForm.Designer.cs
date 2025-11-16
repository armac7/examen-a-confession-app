namespace Examen.src.forms
{
    partial class ConfessionForm
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            restartButton = new Button();
            saveButton = new Button();
            closeButton = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            richTextBox1 = new RichTextBox();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(27, 461);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(780, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(24, 461);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(27, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(753, 56);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(239, 37);
            label1.TabIndex = 0;
            label1.Text = "Confession Guide";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(restartButton);
            flowLayoutPanel4.Controls.Add(saveButton);
            flowLayoutPanel4.Controls.Add(closeButton);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.Location = new Point(27, 389);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(753, 72);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // restartButton
            // 
            restartButton.Location = new Point(3, 3);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(170, 43);
            restartButton.TabIndex = 0;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(179, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(170, 43);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save to PDF";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(355, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(170, 43);
            closeButton.TabIndex = 2;
            closeButton.Text = "Close Program";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(richTextBox1);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(27, 56);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(753, 333);
            flowLayoutPanel5.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(744, 324);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // ConfessionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            MinimumSize = new Size(820, 500);
            Name = "ConfessionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Examen - Confess";
            FormClosing += ConfessionForm_FormClosing;
            Load += ConfessionForm_Load;
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button restartButton;
        private Button saveButton;
        private Button closeButton;
    }
}