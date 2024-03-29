using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using System.ComponentModel.DataAnnotations;

namespace Admin.Models{
    public class Careers{
        [Key]
        public Guid id {get; set;}
        public string? career_name {get; set;}
        public string? career_detail {get; set;}
        public DateTime? career_date{get; set;}
        public string? location { get; set; }
        public string? department { get; set; }
        public int? hiring { get; set; }
        public DateTime? closing_date { get; set; }
        public bool is_active { get; set; }
    }
}