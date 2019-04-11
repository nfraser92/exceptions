using System;
using System.Collections.Generic;

namespace address
{
    public class Contact
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Address {get; set;}

        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }

//     public void Print () {
//         Console.WriteLine($@"
// Contact: {FirstName} {LastName}
// Email:
//         ");
//     }
    }

}