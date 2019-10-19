using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DOB { get; set; }
        string Email { get; set; }
        int PhoneNumber { get; set; }
        string Address { get; set; }
        string State { get; set; }
        string City { get; set; }
        string Zip { get; set; }
        string Country { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string UserType { get; set; }
        bool isActive { get; set; }
        string AvatarURL { get; set; }
    }
}

