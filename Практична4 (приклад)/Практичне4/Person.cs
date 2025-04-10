using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практичне4
{
    internal class Person
    {
        string name;
        int age;
        string profession;
        public Person(string name, int age, string profession)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string GetInformation()
        {
            string information;
            information = "Ім'я: " + this.name + "; Вік: " + this.age.ToString() + "; Професія: " + this.profession;
            return information;
        }

    }
}
