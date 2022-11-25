using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.core
{

    public class User
    {
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string age;

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public readonly DateTime datenaire = DateTime.Now;

        public DateTime Datenaire { get; } = DateTime.Now;



    }
}
