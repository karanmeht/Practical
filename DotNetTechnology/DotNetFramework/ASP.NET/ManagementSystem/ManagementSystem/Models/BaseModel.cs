using System;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}