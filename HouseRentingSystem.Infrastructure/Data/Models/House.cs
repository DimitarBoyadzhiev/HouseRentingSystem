using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;


namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House")]
    public class House
    {
        [Key]
        [Comment("House Identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(HouseTitleMaxLength)]
        [Comment("House title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(HouseAddressMaxLength)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        //[Range(typeof(decimal), HouseRentingPriceMinimum, HouseRentingPriceMaximum, ConvertValueInInvariantCulture = true)]
        [Comment("Montly Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("Category Identifier")]
        public int CategoryId { get; set; }

        [Required]
        [Comment("Agent Identifier")]
        public int AgentId { get; set; }

        [Comment("Renter Identifier")]
        public string? RenterId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;
    }
}
