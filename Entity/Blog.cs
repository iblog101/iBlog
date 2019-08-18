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
            Likes = UserLikes.Count;
        }

        public void Liked(User user)
        {
            UserLikes.Add(user);
            Likes = UserLikes.Count;
        }

        public void DisLiked(User user)
        {
            UserLikes.Remove(user);
            Likes = UserLikes.Count;
        }
    }
}
