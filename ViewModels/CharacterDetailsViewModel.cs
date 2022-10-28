using GenshinDB.Models;

namespace GenshinDB.ViewModels
{
    public class CharacterDetailsViewModel
    {
        public IEnumerable<Characters> Characters { get; set; }
        public Characters Character { get; set; }
        public Nations Nations { get; set; }
        public Visions Visions { get; set; }
        public IEnumerable<CharactersTags> CharactersTags { get; set; }

    }
}