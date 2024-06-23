using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6.Classes.UserAndAdmin
{
    internal class User
    {
        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 50 символов")]
        public string? Name_User { get; set; }

        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 50 символов")]
        public string? Password_User { get; set; }

        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
        ErrorMessage = "Некорректный адрес электронной почты")]
        [StringLength(50, MinimumLength = 12, ErrorMessage = "Длина Email должна быть от 2 до 50 символов")]
        public string? Email_User { get; set; }   

        public User() { }

        public User(string? Name_User, string? Password_User, string? Email_User)
        {
            this.Name_User = Name_User;
            this.Password_User = Password_User;
            this.Email_User = Email_User;
        }
    }
}
