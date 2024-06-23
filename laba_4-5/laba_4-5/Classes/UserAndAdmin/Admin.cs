using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_5.Classes.UserAndAdmin
{
    internal class Admin
    {
        public string? Name_Admin { get; set; }
        public string? Password_Admin { get; set; }
        public string? Email_Admin { get; set; }

        public Admin() { }

        public Admin(string? name_Admin, string? password_Admin, string? email_Admin)
        {
            Name_Admin = name_Admin;
            Password_Admin = password_Admin;
            Email_Admin = email_Admin;
        }
    }
}
