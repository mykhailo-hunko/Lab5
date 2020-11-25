using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Lab5
{
    public partial class Form1 : Form
    {

        // List<Person> list = new List<Person>();
        private BindingSource BindingSource1 = new BindingSource();
        
        

        List<Person> list;
        //BindingList<Person> list;

        public Form1()
        {
            list = new List<Person>();
            //   list = new BindingList<Person>(list);
            BindingSource1.DataSource = list;
            InitializeComponent();
            dataGridView1.DataSource = BindingSource1;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string teacher = Teacher.Text;
            string subject = textSubj.Text;

            if(string.IsNullOrEmpty(teacher) || string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("Ошибка. Правильно заполните поля!");
            }
            else
            {
                list.Add(new Person(teacher, subject));
               
            }
            BindingSource1.ResetBindings(true);
        }//done

        private void TeacherOn_Click(object sender, EventArgs e)
        {

            string s = textSubject.Text;
            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            var selectedUsers = (from user in list where user.name == s select user.subject).ToList();
            string result = "";
            foreach (string user in selectedUsers)
            {
                result += user + "\n";
            }

            if (result.Equals(""))
            {
                MessageBox.Show("Предметов не найдено!");
            }
            else
            {
                MessageBox.Show(result);
            }
           
        }//done

        private void SubjectOn_Click(object sender, EventArgs e)
        {
            string s = textTeacher.Text;
            if (string.IsNullOrEmpty(s))
            {
                return;
            }

            var selectedUsers = (from user in list where user.subject == s select user.name).ToList();
            string result = "";
            foreach (string user in selectedUsers)
            {
                result += user + "\n";
            }

            if (result.Equals(""))
            {
                MessageBox.Show("Преподавателей не найдено!");
            }
            else
            {
                MessageBox.Show(result);
            }
        }//done

        private void Save_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));


            using (FileStream fs = new FileStream(@"D:\lab5.xml", FileMode.Truncate))
            {
                formatter.Serialize(fs, list);
            }
        }//done

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(textIndex.Text) - 1;
                string teacher = dataGridView1.Rows[index].Cells["name"].Value.ToString();
                string subject = dataGridView1.Rows[index].Cells["subject"].Value.ToString();

               var indexOf = list.FindIndex(x => x.name == teacher && x.subject == subject);
                list.RemoveAt(indexOf);
                BindingSource1.ResetBindings(true);
            }
            catch
            {
                return;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));


            using (FileStream fs = new FileStream(@"D:\lab5.xml", FileMode.Open))
            {
                list = (List<Person>)formatter.Deserialize(fs);
            }
            BindingSource1.DataSource = list;
            BindingSource1.ResetBindings(true);
        }//done

        private void sortUp_Click(object sender, EventArgs e)//done
        {
            var newList = list.OrderBy(p => p.name).ToList(); //.Sort((Person x, Person y) => x.name.CompareTo(y.name));
            list = newList;
            BindingSource1.DataSource = list;
            BindingSource1.ResetBindings(false);

        }

        private void sortDown_Click(object sender, EventArgs e)//done
        {
            var newList = list.OrderByDescending(p => p.name).ToList(); //.Sort((Person x, Person y) => x.name.CompareTo(y.name));
            list = newList;
            BindingSource1.DataSource = list;
            BindingSource1.ResetBindings(false);
        }
    }
}
