using System.ComponentModel.DataAnnotations;

namespace GenshinDB.Models
{
    public class WeaponSubStatusType
    {
        [Key]
        public string WeaponSubStatusTypeId { get; set; }
        [Required,StringLength(20)]
        public string WeaponSubStatusTypeName { get; set; }

        public List<Weapons> Weapons { get; set; }
    }
}
