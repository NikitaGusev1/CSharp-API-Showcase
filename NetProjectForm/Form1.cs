using GetRequestAndParse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetProjectForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.AddRange(new string[] { "Nerdy", "Explicit" });
            comboBox1.SelectedText = "Select a category";
            richTextBox1.Text = "Choose a category of jokes!";
            //var exp = new List<string>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await ReqParse.GetReq();
            var lst = new List<string>();
            //foreach(var i in lst)
            //richTextBox1.Text = result.value[0].joke.ToString();
            if (comboBox1.SelectedIndex == 0)
            {
                foreach (var i in result.value)
                {
                    foreach (var j in i.categories)
                    {
                        if (j == "nerdy")
                        {
                            lst.Add(i.joke.ToString());
                        }
                    }
                }
                richTextBox1.Text = String.Join("\n\n", lst);
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                foreach (var i in result.value)
                {
                    foreach (var j in i.categories)
                    {
                        if (j == "explicit")
                        {
                            lst.Add(i.joke.ToString());
                        }
                    }
                }
                richTextBox1.Text = String.Join("\n\n", lst);
            }
            //else if (comboBox1.SelectedIndex == 2)
            //{
                
            //}
            else
            {
                richTextBox1.Text = "Choose a category!";
            }
        }
            

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var result1 = await ReqParse.GetReq();
            var all = new List<string>();
            foreach(var i in result1.value)
            {
                all.Add(i.joke.ToString());
            }
            richTextBox1.Text = String.Join("\n\n", all);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
