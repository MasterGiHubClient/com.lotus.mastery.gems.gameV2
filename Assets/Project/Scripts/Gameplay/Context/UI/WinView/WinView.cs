using System;
using UnityEngine;

public class WinView : MonoBehaviour
{
    public event Action Win;

    [SerializeField] private GameObject _view;

    public void Enable()
    {
        _view.SetActive(true);
        Win?.Invoke();
    }
}