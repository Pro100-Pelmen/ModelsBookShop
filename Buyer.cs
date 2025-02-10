using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsBookShop
{
    internal class Buyer
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<Order> OrderId { get; set; }

        public Buyer() { }

        public Buyer (
            string lastname, 
            string firstname, 
            string patronymic, 
            string phone, 
            string login, 
            string password)
        {
            Lastname = lastname;
            Firstname = firstname;
            Patronymic = patronymic;
            Phone = phone;
            Login = login;
            Password = password;
        }
    }
}
