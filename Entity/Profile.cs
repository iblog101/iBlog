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
            //profile
            ProfileUser = user;
            ProfileUserID = user.ID;
            //followers
            Followers = new List<User>();
            FollowersCount = TotalFollowerCount();
            //block list
            BlockList = new List<User>();
            BlockCount = TotalBlockListCount(); ;

            isActive = true;
        }

        //Have to update following user Followers and FollowersCount in profile  
        public void Follow(User user)
        {
            if (!FollowerCountIsFull())
            {
                Following.Add(user);
            }
            else
            {
                // Follower count is full int max
            }
           
        }

        //Have to update following user Followers and FollowersCount in profile  
        public void UnFollow(User user)
        {
            if (!FollowerCountIsEmpty())
            {
                Following.Remove(user);
            }
            else
            {
                //follower count is empty
            }
           
        }
        public int TotalFollowerCount()
        {
            return FollowingCount = Followers.Count;
        }

        public bool FollowerCountIsEmpty()
        {
            return FollowersCount == 0;
        }

        public bool FollowerCountIsFull()
        {
            return FollowersCount == int.MaxValue;
        }

        public int TotalBlockListCount()
        {
            return BlockCount = BlockList.Count;
        }

        public bool BlockListIsEmpty()
        {
            return BlockCount == 0;
        }

        public bool BlockListIsFull()
        {
            return BlockCount == int.MaxValue;
        }


        public void Block(User user)
        {
            if (!BlockListIsFull())
            {
                BlockList.Add(user);
            }
            else
            {
                //Block List is full int max
            }
           
        }

        public void UnBlock(User user)
        {
            if (!BlockListIsEmpty())
            {
                BlockList.Remove(user);
            }
            else
            {
                //Block List count is empty
            }
        }

    }
}
