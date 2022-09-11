using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShell : MonoBehaviour
{
    private Character _character;

    public Character Character { set => _character = value; }

    private void Update()
    {
        _character.Attack();
    }
}
