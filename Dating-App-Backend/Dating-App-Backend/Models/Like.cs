using System;
namespace Dating_App_Backend.Models
{
    public class Like
    {
        public int  LikerId { get; set; }

        public int LikeeId { get; set; }

        public virtual User Liker { get; set; }

        public virtual User Likee { get; set; }

    }
}
