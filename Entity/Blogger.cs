using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Blogger : User
    {
   
        public List<Blog> BlogList { get; set; }

        public Blogger()
        {
            isActive = true;
            UserType = "Blogger";
            BlogList = new List<Blog>();
        }


    }
}
