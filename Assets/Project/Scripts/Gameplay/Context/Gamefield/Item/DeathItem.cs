using UnityEngine;
using Zenject;

public class DeathItem : Item
{
    [Inject] private readonly WinView _winView;

    protected override void TriggerEnter(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerScore playerScore))
        {
            _winView.Enable();

            Destroy(playerScore.gameObject);
            Destroy(gameObject);
        }
    }
}