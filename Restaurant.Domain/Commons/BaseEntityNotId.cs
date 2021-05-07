using System;

namespace Restaurant.Domain.Entities.Commons
{
    public abstract class BaseEntityNotId  
    {
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public bool IsCanceled { get; set; } = false;
        public DateTime? RemoveTime { get; set; }
    }
}
