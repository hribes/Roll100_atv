using Roll100.DTO;
using Roll100.Entities;

namespace Roll100.Interfaces.IServices
{
    public interface ICharacterService
    {
        public void Create(CreateCharacterDTO character);
        public Character GetCharacterByName(string name);
        public List<Character> GetCharacters();
        public Character GetCharacterById(int id);
    }
}
