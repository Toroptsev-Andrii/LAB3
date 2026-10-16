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
    public partial class Form2 : Form
    {
        dbManager db = dbManager.getInstance();
        DocSaver docSaver = DocSaver.getInstance();
        LoggerClass logger = LoggerClass.getInstance();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db.Select("testtable");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int a) && int.TryParse(textBox2.Text, out int b))
            {
                int res = a + b;
                logger.logging($"calculate: {a} + {b} = {res}");
                MessageBox.Show($"Результат: {res}");
            }
            else
            {
                logger.logging($"User input error: '{textBox1.Text}', '{textBox2.Text}'");
                MessageBox.Show("Введіть коректні числа");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.GetTables();
            docSaver.Save("Report.docx");
            MessageBox.Show("Запити до БД та збереження документа виконано");
        }
    }
}