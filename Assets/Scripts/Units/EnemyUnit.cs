using UnityEngine;

public class EnemyUnit : Unit
{
    protected override void Die()
    {
        Destroy(gameObject);
    }
}
