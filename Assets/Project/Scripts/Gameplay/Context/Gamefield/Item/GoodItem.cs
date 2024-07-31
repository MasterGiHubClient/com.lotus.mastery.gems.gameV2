using UnityEngine;

public class GoodItem : Item
{
    [SerializeField] private int Coast;

    protected override void TriggerEnter(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerScore component))
        {
            component.Add(Coast);
            Restart();
        }
    }
}