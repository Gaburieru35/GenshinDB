using System.ComponentModel.DataAnnotations;

namespace GenshinDB.Models
{
    public class Visions
    {
        [Key]
        public int VisionId { get; set; } 
        public int VisionElement { get; set; }
        public string VisionEffectStatus { get; set; }
        public string VisionReactionDescription { get; set; }

        public List<Characters> Characters { get; set; }
    }
}
