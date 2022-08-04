using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinDB.Models
{
    public class Weapons
    {
        [Key]
        public int WeaponID { get; set; }
        [Required]
        public int WeaponType { get; set; }
        [Required]
        [StringLength(50)]
        public string WeaponName { get; set; }
        [Required]
        [StringLength(10)]
        public string WeaponBaseATQ { get; set; }
        [Required]
        [Column(TypeName = "decimal(3, 1)")]
        public decimal WeaponSubStatusValue { get; set; }

        [Required,StringLength(300)]
        public string WeaponDescription { get; set; }
        public string WeaponImageURL { get; set; }
        [Required]
        public string WeaponRarity { get; set; }
        [ForeignKey("WeaponSubStatusTypeId")]
        public int WeaponSubStatusTypeId { get; set; }
        public virtual WeaponSubStatusType WeaponSubStatusType { get; set; }

    }
}
