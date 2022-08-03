using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinDB.Models
{
    public class Nations
    {
        [Key]
        public int NationId { get; set; }

        [Required]
        [StringLength(30)]
        public string NationName { get; set; }

        [Required]
        [StringLength(200)]
        public string NationDescription { get; set; }

        public List<Characters> Characters { get; set; }

    }
}
