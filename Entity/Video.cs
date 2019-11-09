using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Video
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VideoId { get; set; }

        [ForeignKey("User")]
        public int ID { get; set; }
        public User User { get; set; }

        public byte[] VideoData { get; set; }

        public string Size { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
