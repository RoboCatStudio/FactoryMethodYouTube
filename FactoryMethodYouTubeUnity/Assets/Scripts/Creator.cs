using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creator : MonoBehaviour
{
    public abstract Character CreateCharacterInstance();
    public abstract GameObject AddCharacterInstance(GameObject character);
    public abstract void InstantiateGameObject();
}
