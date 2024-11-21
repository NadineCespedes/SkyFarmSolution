namespace SkyFarm
{
    partial class BoxMessage
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
            lbStatus = new Label();
            lbDescricao = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStatus.Location = new Point(28, 21);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(128, 50);
            lbStatus.TabIndex = 0;
            lbStatus.Text = "label1";
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescricao.Location = new Point(28, 19);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(386, 25);
            lbDescricao.TabIndex = 1;
            lbDescricao.Text = "label2 jaklshdoasj alkjshdaksljdh kajshdaksjd";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(lbStatus);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 100);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.Controls.Add(lbDescricao);
            panel2.Location = new Point(12, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 149);
            panel2.TabIndex = 3;
            // 
            // BoxMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 289);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BoxMessage";
            Text = "BoxMessage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbStatus;
        private Label lbDescricao;
        private Panel panel1;
        private Panel panel2;
    }
}