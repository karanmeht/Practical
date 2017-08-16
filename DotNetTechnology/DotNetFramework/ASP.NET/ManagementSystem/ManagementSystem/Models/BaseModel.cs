using System;

namespace ManagementSystem.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}