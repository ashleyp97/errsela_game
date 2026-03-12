namespace pantest
{
    partial class Form1
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panel1 = new Panel();
			label1 = new Label();
			panel2 = new Panel();
			label5 = new Label();
			button2 = new Button();
			button1 = new Button();
			button3 = new Button();
			button4 = new Button();
			panel3 = new Panel();
			label7 = new Label();
			button8 = new Button();
			button7 = new Button();
			label4 = new Label();
			splitContainer1 = new SplitContainer();
			label6 = new Label();
			label3 = new Label();
			button5 = new Button();
			textBox3 = new TextBox();
			label2 = new Label();
			Control = new Label();
			toolStripContainer1 = new ToolStripContainer();
			button6 = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			button9 = new Button();
			pictureBox2 = new PictureBox();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			toolStripContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(label1);
			panel1.Location = new Point(142, 173);
			panel1.Name = "panel1";
			panel1.Size = new Size(536, 77);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(19, 10);
			label1.Name = "label1";
			label1.Size = new Size(499, 54);
			label1.TabIndex = 0;
			label1.Text = "ERRSELA's Delivery Service";
			label1.Click += label1_Click_1;
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(label5);
			panel2.Location = new Point(142, 269);
			panel2.Name = "panel2";
			panel2.Size = new Size(997, 113);
			panel2.TabIndex = 1;
			panel2.Paint += panel2_Paint;
			// 
			// label5
			// 
			label5.BackColor = Color.Lavender;
			label5.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(31, 22);
			label5.Name = "label5";
			label5.Size = new Size(928, 64);
			label5.TabIndex = 5;
			label5.Text = "Help ERRSELA deliver all her packages to the correct spot. Answer a math problem correctly and she'll move. Quick before she runs out of time! Hit Begin to start.";
			// 
			// button2
			// 
			button2.Cursor = Cursors.SizeNESW;
			button2.Font = new Font("Segoe UI", 12F);
			button2.Location = new Point(49, 533);
			button2.Name = "button2";
			button2.Size = new Size(233, 48);
			button2.TabIndex = 2;
			button2.Text = "BACKWARDS";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Cursor = Cursors.SizeNESW;
			button1.Font = new Font("Segoe UI", 12F);
			button1.Location = new Point(49, 451);
			button1.Name = "button1";
			button1.Size = new Size(233, 50);
			button1.TabIndex = 1;
			button1.Text = "FORWARD";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button3
			// 
			button3.Cursor = Cursors.SizeNESW;
			button3.Font = new Font("Segoe UI", 12F);
			button3.Location = new Point(49, 611);
			button3.Name = "button3";
			button3.Size = new Size(233, 42);
			button3.TabIndex = 3;
			button3.Text = "LEFT";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Cursor = Cursors.SizeNESW;
			button4.Font = new Font("Segoe UI", 12F);
			button4.Location = new Point(46, 688);
			button4.Name = "button4";
			button4.Size = new Size(236, 46);
			button4.TabIndex = 3;
			button4.Text = "RIGHT";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(label7);
			panel3.Controls.Add(button8);
			panel3.Controls.Add(button7);
			panel3.Controls.Add(label4);
			panel3.Controls.Add(splitContainer1);
			panel3.Location = new Point(142, 403);
			panel3.Name = "panel3";
			panel3.Size = new Size(1807, 971);
			panel3.TabIndex = 2;
			panel3.Paint += panel3_Paint;
			// 
			// label7
			// 
			label7.BackColor = Color.Lavender;
			label7.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(1470, 223);
			label7.Name = "label7";
			label7.Size = new Size(166, 38);
			label7.TabIndex = 5;
			label7.Text = "Timer";
			label7.TextAlign = ContentAlignment.TopCenter;
			// 
			// button8
			// 
			button8.Font = new Font("Garamond", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button8.Location = new Point(1613, 373);
			button8.Name = "button8";
			button8.Size = new Size(126, 42);
			button8.TabIndex = 4;
			button8.Text = "Start";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button7
			// 
			button7.Font = new Font("Garamond", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button7.Location = new Point(1470, 373);
			button7.Name = "button7";
			button7.Size = new Size(126, 42);
			button7.TabIndex = 3;
			button7.Text = "Stop";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// label4
			// 
			label4.BorderStyle = BorderStyle.FixedSingle;
			label4.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(1470, 279);
			label4.Name = "label4";
			label4.Size = new Size(269, 67);
			label4.TabIndex = 2;
			label4.Text = "label4";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// splitContainer1
			// 
			splitContainer1.Location = new Point(20, 72);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(label6);
			splitContainer1.Panel1.Controls.Add(label3);
			splitContainer1.Panel1.Controls.Add(button5);
			splitContainer1.Panel1.Controls.Add(textBox3);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(Control);
			splitContainer1.Panel1.Controls.Add(button4);
			splitContainer1.Panel1.Controls.Add(button1);
			splitContainer1.Panel1.Controls.Add(button3);
			splitContainer1.Panel1.Controls.Add(button2);
			splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(pictureBox2);
			splitContainer1.Panel2.Click += button5_Click;
			splitContainer1.Size = new Size(1415, 815);
			splitContainer1.SplitterDistance = 471;
			splitContainer1.TabIndex = 1;
			// 
			// label6
			// 
			label6.BackColor = Color.Lavender;
			label6.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(43, 322);
			label6.Name = "label6";
			label6.Size = new Size(379, 96);
			label6.TabIndex = 6;
			label6.Text = "Choose a direction and answer a math problem. If you answer correctly the robot will move!";
			// 
			// label3
			// 
			label3.BorderStyle = BorderStyle.FixedSingle;
			label3.Location = new Point(43, 258);
			label3.Name = "label3";
			label3.Size = new Size(266, 38);
			label3.TabIndex = 8;
			label3.Text = "This was..";
			// 
			// button5
			// 
			button5.Font = new Font("Garamond", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button5.Location = new Point(295, 184);
			button5.Name = "button5";
			button5.Size = new Size(160, 41);
			button5.TabIndex = 6;
			button5.Text = "Submit";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(43, 184);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(236, 31);
			textBox3.TabIndex = 5;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// label2
			// 
			label2.BorderStyle = BorderStyle.FixedSingle;
			label2.Font = new Font("Garamond", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(43, 111);
			label2.MaximumSize = new Size(300, 0);
			label2.Name = "label2";
			label2.Size = new Size(300, 52);
			label2.TabIndex = 4;
			label2.Text = "Question box";
			label2.Click += label1_Click_1;
			// 
			// Control
			// 
			Control.AutoSize = true;
			Control.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Control.Location = new Point(38, 25);
			Control.Name = "Control";
			Control.Size = new Size(333, 54);
			Control.TabIndex = 3;
			Control.Text = "Command Center";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			toolStripContainer1.ContentPanel.Size = new Size(225, 237);
			toolStripContainer1.Location = new Point(1709, 1086);
			toolStripContainer1.Name = "toolStripContainer1";
			toolStripContainer1.Size = new Size(225, 262);
			toolStripContainer1.TabIndex = 3;
			toolStripContainer1.Text = "toolStripContainer1";
			// 
			// button6
			// 
			button6.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.Location = new Point(1177, 292);
			button6.Name = "button6";
			button6.Size = new Size(220, 55);
			button6.TabIndex = 4;
			button6.Text = "BEGIN";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// button9
			// 
			button9.Font = new Font("Garamond", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button9.Location = new Point(1428, 292);
			button9.Name = "button9";
			button9.Size = new Size(220, 55);
			button9.TabIndex = 5;
			button9.Text = "FINISH";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Location = new Point(3, 85);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(937, 649);
			pictureBox2.TabIndex = 0;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(2002, 1403);
			Controls.Add(button9);
			Controls.Add(button6);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(toolStripContainer1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			toolStripContainer1.ResumeLayout(false);
			toolStripContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Panel panel3;
		private SplitContainer splitContainer1;
		private Label Control;
		private ToolStripContainer toolStripContainer1;
		private Button button5;
		private PictureBox pictureBox1;
		private Label label2;
		private TextBox textBox3;
		private Label label3;
		private Button button6;
		private System.Windows.Forms.Timer timer1;
		private Label label4;
		private Button button7;
		private Button button8;
		private Label label5;
		private Label label6;
		private Label label7;
		private Button button9;
		private PictureBox pictureBox2;
	}
}
