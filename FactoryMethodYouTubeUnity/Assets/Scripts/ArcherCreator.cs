using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherCreator : Creator
{
    [SerializeField] private GameObject _character;

    public override Character CreateCharacterInstance()
    {
        return new Archer();
    }

    public override GameObject AddCharacterInstance(GameObject character)
    {
        if (character.TryGetComponent(out CharacterShell characterShell))
        {
            characterShell.Character = CreateCharacterInstance();
        }
        else Debug.LogWarning("CharacterShell is not found");
        return character;
    }

    public override void InstantiateGameObject()
    {
        GameObject character = Instantiate(_character, transform.position, transform.rotation);
        character.SetActive(false);
        AddCharacterInstance(character);
        character.SetActive(true);
    } 
}
