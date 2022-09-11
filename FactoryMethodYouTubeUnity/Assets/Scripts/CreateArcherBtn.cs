using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateArcherBtn : MonoBehaviour
{
    [SerializeField] private GameObject _archerCreator;
    private Button _archerCreatorButton;

    private void Start()
    {
        gameObject.TryGetComponent(out _archerCreatorButton);
        _archerCreatorButton.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        _archerCreator.TryGetComponent(out ArcherCreator archerCreator);
        archerCreator.InstantiateGameObject();
    }
}
