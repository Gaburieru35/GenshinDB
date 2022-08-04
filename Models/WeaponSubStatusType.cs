using System.ComponentModel.DataAnnotations;

namespace GenshinDB.Models
{
    public class WeaponSubStatusType
    {
        public int WeaponSubStatusTypeId { get; set; }
        [Required,StringLength(20)]
        public string WeaponSubStatusTypeName { get; set; }

        public List<Weapons> Weapons { get; set; }
    }
}
