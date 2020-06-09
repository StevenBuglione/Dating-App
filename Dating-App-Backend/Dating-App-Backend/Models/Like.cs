using System;
namespace Dating_App_Backend.Models
{
    public class Like
    {
        public int  LikerId { get; set; }

        public int LikeeId { get; set; }

        public User Liker { get; set; }

        public User Likee { get; set; }

    }
}
