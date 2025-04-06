using UnityEngine;
public enum Team
{
    Friendly,
    Enemy
}

public abstract class Unit : MonoBehaviour
{
    public Team Team { get; private set; }

    public float Health { get; protected set; }
    public float MaxHealth { get; protected set; }
    public bool IsAlive => Health > 0;
    public void Initialize(Team team)
    {
        Team = team;
        Health = MaxHealth;
    }
    public virtual void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Die();
        }
    }
    protected abstract void Die();

}
