﻿
namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } 
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
