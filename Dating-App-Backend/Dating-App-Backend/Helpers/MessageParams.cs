using System;
namespace Dating_App_Backend.Helpers
{
    public class MessageParms
    {
        private const int MaxPageSize = 50;

        public int PageNumber { get; set; } = 1;

        private int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }


        public int UserId { get; set; }

        public string MessageContainer { get; set; } = "Unread";
    }
}
