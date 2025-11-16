namespace Examen
{
    partial class PrayerForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            flow = new FlowLayoutPanel();
            prayerPanel = new FlowLayoutPanel();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(39, 461);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(416, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(38, 461);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Controls.Add(label2);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(39, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(377, 56);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(298, 28);
            label1.TabIndex = 0;
            label1.Text = "Common Confessional Prayers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(229, 15);
            label2.TabIndex = 1;
            label2.Text = "Click a prayer to add it to your confession.";
            // 
            // flow
            // 
            flow.AutoScroll = true;
            flow.Dock = DockStyle.Bottom;
            flow.Location = new Point(39, 434);
            flow.Name = "flow";
            flow.Size = new Size(377, 27);
            flow.TabIndex = 3;
            // 
            // prayerPanel
            // 
            prayerPanel.AutoScroll = true;
            prayerPanel.Dock = DockStyle.Fill;
            prayerPanel.Location = new Point(39, 56);
            prayerPanel.Name = "prayerPanel";
            prayerPanel.Size = new Size(377, 378);
            prayerPanel.TabIndex = 4;
            // 
            // PrayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 461);
            Controls.Add(prayerPanel);
            Controls.Add(flow);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            MaximumSize = new Size(470, 1000);
            MinimumSize = new Size(470, 500);
            Name = "PrayerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Examen - Prayers";
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flow;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel prayerPanel;
    }
}