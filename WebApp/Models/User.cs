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
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Date)]
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
