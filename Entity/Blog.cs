using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity
{
   public class Blog
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
        //[NotMapped]
        public User User { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(20)]
        public string Subject { get; set; }
        [Required]
        [MaxLength(1000)]
        public string MessageBody { get; set; }
        [Required]
        public bool isActive { get; set; }
        [NotMapped]
        public List<User> UserLikes { get; set; }
        public int Likes { get; set; }


        public Blog()
        {
            Date = DateTime.Now;
            isActive = true;
            UserLikes = new List<User>();
            Likes = TotalLikes();
        }

        public bool LikedIsFull()
        {
            return Likes == int.MaxValue;
        }

        public bool LikedIsEmpty()
        {
            return Likes == 0;
        }

        public void Liked(User user)
        {
            if (!LikedIsFull())
            {
                UserLikes.Add(user);
            }
            else
            {
                // user likes is full
            }
        }

        public void DisLiked(User user)
        {
            if (!LikedIsEmpty())
            {
                UserLikes.Remove(user);
            }
            else
            {
                // user likes is empty
            }
        }



        public int TotalLikes()
        {   
            return Likes = UserLikes.Count;
        }

        
    }
}
