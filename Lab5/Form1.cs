using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
            if(dataGridView1.ColumnCount == 0)
            {
                return;
            }
            if(list.Exists(x => x.name == teacher) && list.Exists(x => x.subject == subject))
            {
                MessageBox.Show("Такая пара значений уже есть!");
            }
            else
            {
                list.Add(new Person(teacher, subject));
                ds.Tables[0].Rows.Add(teacher, subject);
            }
            
        }

        private void TeacherOn_Click(object sender, EventArgs e)
        {
            string s = textSubject.Text;
            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            var selectedUsers = (from user in list where user.subject == s select user.name).ToList();
            string result = null;
            foreach(string user in selectedUsers)
            {
                result += user + "\n";
            }

            if(result == null)
            {
                MessageBox.Show("Преподавателей не найдено!");
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void SubjectOn_Click(object sender, EventArgs e)
        {
            string s = textSubject.Text;
            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            var selectedUsers = (from user in list where user.subject == s select user.name).ToList();
            string result = null;
            foreach (string user in selectedUsers)
            {
                result += user + "\n";
            }

            if (result == null)
            {
                MessageBox.Show("Предметов не найдено!");
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(list.Count == 0)
            {
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.Tables[0].WriteXml(sfd.FileName);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(textIndex.Text) - 1;
                string teacher = dataGridView1.Rows[index].Cells["Name"].Value.ToString();
                string subject = dataGridView1.Rows[index].Cells["Subject"].Value.ToString();

                var indexOf = list.FindIndex(x => x.name == teacher && x.subject == subject);
                list.RemoveAt(indexOf);
                ds.Tables[0].Rows.RemoveAt(index);
            }
            catch
            {
                return;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReader xmlFile = XmlReader.Create(ofd.FileName, new XmlReaderSettings());
                    ds.ReadXml(xmlFile);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.RemoveAt(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}
