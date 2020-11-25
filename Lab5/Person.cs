using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    [Serializable]
    public class Person
    {
        
        public string name { get; set; }
        public string subject { get; set; }

        public Person()
        {
        }

        public Person(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }
    }
}
