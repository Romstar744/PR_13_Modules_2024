namespace Пр_13_3
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
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btnChange = new Button();
			btnDefine = new Button();
			btnExit = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 22);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = ScrollBars.Both;
			textBox1.Size = new Size(416, 352);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(434, 25);
			label1.Name = "label1";
			label1.Size = new Size(167, 30);
			label1.TabIndex = 1;
			label1.Text = "Количество подряд \r\nрасположенных символов =";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(393, 22);
			label2.Name = "label2";
			label2.Size = new Size(0, 15);
			label2.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(607, 25);
			label3.Name = "label3";
			label3.Size = new Size(0, 15);
			label3.TabIndex = 3;
			label3.Click += label3_Click;
			// 
			// btnChange
			// 
			btnChange.Location = new Point(521, 227);
			btnChange.Name = "btnChange";
			btnChange.Size = new Size(155, 39);
			btnChange.TabIndex = 4;
			btnChange.Text = "Корректировать";
			btnChange.UseVisualStyleBackColor = true;
			btnChange.Click += btnChange_Click;
			// 
			// btnDefine
			// 
			btnDefine.Location = new Point(521, 182);
			btnDefine.Name = "btnDefine";
			btnDefine.Size = new Size(155, 39);
			btnDefine.TabIndex = 5;
			btnDefine.Text = "Определить";
			btnDefine.UseVisualStyleBackColor = true;
			btnDefine.Click += btnDefine_Click;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(521, 272);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(155, 39);
			btnExit.TabIndex = 6;
			btnExit.Text = "Выход";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnExit);
			Controls.Add(btnDefine);
			Controls.Add(btnChange);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnChange;
		private Button btnDefine;
		private Button btnExit;
	}
}
