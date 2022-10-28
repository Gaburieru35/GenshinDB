using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace GenshinDB.Models
{
    public class CharactersTags
    {
        [Required]
        public string TagsId { get; set; }
        public string TagsName { get; set; }
        [Key]
        public int CharactersIdTags { get; set; }
        public List<Characters> Characters { get; set; }
    }
}
