using UnityEngine;
using Zenject;

public class Destroyable : MonoBehaviour
{
    [Inject] private readonly WinView _winView;

    private void Awake() => _winView.Win += Destroy;
    private void Destroy() => Destroy(gameObject);
    private void OnDestroy() => _winView.Win -= Destroy;
}