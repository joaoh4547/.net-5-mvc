using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é Obrigatorio")]
        [Display(Name ="Nome")]
        public string FirstName { get; set; }
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "A Data de nascimento é obrigatoria")]
        public DateTime BirthDate { get; set; }


        public User()
        {

        }

        public User(int id, string firstName, string lastName, string email, DateTime birthDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
