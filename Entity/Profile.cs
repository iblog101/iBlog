using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
     public class Profile
    {
        [Key]
        public int ID { get; set; }

       // [NotMapped]
        public User ProfileUser { get; set; }

        [ForeignKey("Users")]
        public int ProfileUserID { get; set; }

        [NotMapped]
        public List<User> Followers { get; set; }

        public int FollowersCount { get; set; }

        [NotMapped]
        public List<User> Following { get; set; }

        public int FollowingCount { get; set; }

        [NotMapped]
        public List<User> BlockList { get; set; }

        public int BlockCount { get; set; }

        public bool isActive { get; set; }

        public Profile()
        {

        }

        public Profile(User user)
        {
            ProfileUser = user;
            ProfileUserID = user.ID;
            Followers = new List<User>();
            FollowersCount = Followers.Count;
            Following = new List<User>();
            FollowingCount = Following.Count;
            BlockList = new List<User>();
            BlockCount = BlockList.Count;
            isActive = true;
        }

        //Have to update following user Followers and FollowersCount in profile  
        public void Follow(User user)
        {
            Following.Add(user);
            FollowingCount = Followers.Count;
        }

        //Have to update following user Followers and FollowersCount in profile  
        public void UnFollow(User user)
        {
            Following.Remove(user);
            FollowingCount = Followers.Count;
        }

        public void Block(User user)
        {
            BlockList.Add(user);
            BlockCount = BlockList.Count;
        }

        public void UnBlock(User user)
        {
            BlockList.Remove(user);
            BlockCount = BlockList.Count;
        }


    }
}
