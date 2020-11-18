using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {

        List<Person> list = new List<Person>();
        private BindingSource BindingSource1 = new BindingSource();

        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string teacher = Teacher.Text;
            string subject = textSubj.Text;

            if(string.IsNullOrEmpty(teacher) || string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Ошибка. Правильно заполните поля!");
                return;
            }
            
        }
    }
}
