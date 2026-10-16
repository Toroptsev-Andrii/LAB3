using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Singleton_Library;

namespace КПЗ_лаб_3
{
    public partial class Form1 : Form
    {
        dbManager db = dbManager.getInstance();
        LoggerClass logger = LoggerClass.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logger.logging("Form1 loaded");
            UpdateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.logging("open form2");
            Form2 f = new Form2();
            f.ShowDialog();
            UpdateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var item in logger.info)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
