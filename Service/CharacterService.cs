using Lotr_api;

public class CharacterService : ICharacterService
{
    private readonly List<LotrCharacters> _characters = new List<LotrCharacters>
    {
        new LotrCharacters { Name = "Arwen" },
        new LotrCharacters { Name = "Aragorn" },
        new LotrCharacters { Name = "Gimli" },
        new LotrCharacters { Name = "Frodo" },
        new LotrCharacters { Name = "Gollum" },
        new LotrCharacters { Name = "Legolas" },
        new LotrCharacters { Name = "Bilbo" },
        new LotrCharacters { Name = "Saruman" },
        new LotrCharacters { Name = "Gandalf" },
        new LotrCharacters { Name = "Elrond" }
    };

    public IEnumerable<LotrCharacters> GetAllCharacters()
    {
        return _characters;
    }
    public LotrCharacters GetCharacterByName(string name)
    {
        return _characters.FirstOrDefault(c => c.Name == name)!;
    }
    public void AddCharacter(LotrCharacters character)
    {
        if (character != null && !_characters.Any(c => c.Name == character.Name))
        {
            _characters.Add(character);
        }
    }
}