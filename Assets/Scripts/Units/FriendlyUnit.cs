using UnityEngine;
public class FriendlyUnit : Unit
{
    protected override void Die()
    {
        Destroy(gameObject);
    }
}
