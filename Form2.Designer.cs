namespace pantest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            Control = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(Control);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(2161, 899);
            splitContainer1.SplitterDistance = 719;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 144);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 7;
            label1.Text = "The Goal";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 687);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(173, 209);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Control
            // 
            Control.AutoSize = true;
            Control.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Control.ForeColor = Color.MidnightBlue;
            Control.Location = new Point(27, 37);
            Control.Margin = new Padding(2, 0, 2, 0);
            Control.Name = "Control";
            Control.Size = new Size(501, 48);
            Control.TabIndex = 4;
            Control.Text = "E.R.R.S.E.L.A's Delivery Mission";
            Control.Click += Control_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1355, 817);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(19, 14);
            label2.Name = "label2";
            label2.Size = new Size(177, 37);
            label2.TabIndex = 7;
            label2.Text = "How To Play";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(38, 290);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 367);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(481, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 367);
            panel3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(27, 14);
            label3.Name = "label3";
            label3.Size = new Size(148, 37);
            label3.TabIndex = 7;
            label3.Text = "Directions";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(2161, 899);
            Controls.Add(splitContainer1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label Control;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label2;
    }
}