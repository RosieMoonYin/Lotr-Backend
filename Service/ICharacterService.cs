using Lotr_api;

public interface ICharacterService
{
    IEnumerable<LotrCharacters> GetAllCharacters();
    LotrCharacters GetCharacterByName(string name);
    void AddCharacter(LotrCharacters character);
}

