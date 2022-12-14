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
        public int CharactersRarity { get; set; }
        [Required,StringLength(30)]
        public string CharactersTitle { get; set; }

        [Required]
        [StringLength(600)]
        public string CharactersDescription { get; set; }

        [StringLength(300)]
        public string CharactersImageURL { get; set; }
        public int NationID { get; set; }
        public virtual Nations Nation { get; set; }
        public int VisionId { get; set; }
        public virtual Visions Vision { get; set; }

        public string CharactersVoiceActor { get; set; }

        public string CharactersBirthday { get; set; }

        public string CharactersAffiliation {get; set; }

        public virtual CharactersTags CharactersTag { get; set; }
    }
}
