using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinDB.Models
{
    public class Characters
    {

        public int CharactersId { get; set; }

        [Required]
        [StringLength(30)]
        public string CharactersName { get; set; }

        [Required]
        public int CharactersWeapon { get; set; }

        [Required]
        [StringLength(30)]
        public string CharactersConstelation { get; set; }

        [Required]
        public int CharacterRarity { get; set; }

        [Required]
        [StringLength(200)]
        public string CharacterDescription { get; set; }

        [StringLength(300)]
        public string CharacterImageURL { get; set; }
        public int NationID { get; set; }
        public virtual Nations Nation { get; set; }
    }
}
