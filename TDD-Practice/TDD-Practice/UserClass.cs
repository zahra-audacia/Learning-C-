using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Practice
{
    public class User_Class
    {
        public class User
        {
            //field 
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string EyeColour { get; set; }
            public string Email { get; set; }
            public int Height { get; set; }

            //constructor 
            public User(string FirstName, string LastName, DateTime DateOfBirth, string EyeColour, string Email, int Height)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.DateOfBirth = DateOfBirth;
                this.EyeColour = EyeColour;
                this.Email = Email;
                this.Height = Height;
            }
        }
    }
}
