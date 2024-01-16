namespace Пр_13_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			{
				string path = @"D:\колледж\3 курс\C#\ПР13_Модули_2_семестр\text.txt";

				try
				{
					using (StreamReader sr = new StreamReader(path))
					{
						textBox1.Text = sr.ReadToEnd();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ошибка чтения!\n Файл не найден!", "Предупреждение");
				}
			}
		}

		private void btnDefine_Click(object sender, EventArgs e)
		{
			int i = 0, j = 0, mx = 0;
			MessageBox.Show(textBox1.Text.Length.ToString(), "Количество символов в тексте");

			while ((i+j)< textBox1.Text.Length) 
			{
				while (textBox1.Text[i] == 'p' && i < (textBox1.Text.Length - 1)) i++;
				j = 0;
				char c = textBox1.Text[i];
				while (textBox1.Text[i] == c && (i+j)< (textBox1.Text.Length))
				{
					c = textBox1.Text[i+j];
					j++;
				}
				if (mx < j) mx = j - 1;
				i += j - 1;
			}
			label3.Text = mx.ToString();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
