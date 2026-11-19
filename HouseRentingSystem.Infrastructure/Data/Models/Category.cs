using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House Category")]
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [MaxLength(NameLength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        public List<House> Houses { get; set; } = new List<House>();
    }
}
