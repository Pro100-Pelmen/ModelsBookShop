using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsBookShop
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateAccept { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Role Roles {  get; set; }

        public Employee() { }

        public Employee(
            string lastname, 
            string firstname, 
            string patronymic, 
            DateTime dateAccept, 
            string login, 
            string password,
            Role roles)
        {
            Lastname = lastname;
            Firstname = firstname;
            Patronymic = patronymic;
            DateAccept = DateTime.Now;
            Login = login;
            Password = password;
            Roles = roles;
        }
    }
}
