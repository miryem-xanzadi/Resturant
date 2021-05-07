using Restaurant.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restaurant.Domain.Entities
{
    public class BookTable: BaseEntity
    {
        
        public string FullName { get; set; }
        public int Guests { get; set; }
        public string Phone { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateReserve { get; set; }
        [Column(TypeName = "Time")]
        public TimeSpan TimeReserve { get; set; }
        public string Email { get; set; }
        public bool IsCancel { get; set; }
        public string Note { get; set; }
        public Guid FollowId { get; set; }
    }
}
