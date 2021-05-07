using System;

namespace Restaurant.Application.Services.Users.Queries.GetUsers
{
    public class GetBookTableDto
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public int Guests { get; set; }
        public string Phone { get; set; }
        
        public DateTime DateReserve { get; set; }

        public TimeSpan TimeReserve { get; set; }
        public string Email { get; set; }
        public bool IsCancel { get; set; }
        public string Note { get; set; }
        public Guid FollowId { get; set; }
    }
}
