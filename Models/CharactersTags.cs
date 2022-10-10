using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace GenshinDB.Models
{
    public class CharactersTags
    {
        [Required]
        [Key]
        public string TagsId { get; set; }
        public string TagsName { get; set; }
        public int CharactersId { get; set; }

        public virtual Characters Characters { get; set; }
    }
}
