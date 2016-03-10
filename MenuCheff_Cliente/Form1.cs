using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCheff_Cliente
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//Dictionary<int, string> lista = new Dictionary<int, string>();
			comboBox1.Items.Add(new Produto(3, "batatas").name);
			comboBox1.Items.Add(new Produto(4, "banana").name);
			comboBox1.Items.Add(new Produto(7, "sal").name);
			comboBox1.Items.Add(new Produto(9, "lula").name);
			comboBox1.Items.Add(new Produto(31, "dilma").name);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(comboBox1.SelectedItem);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Remove(listBox1.SelectedItem);
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}
