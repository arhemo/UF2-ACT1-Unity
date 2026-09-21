using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int health = 100;

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int newHealth)
    {
        health = Mathf.Clamp(newHealth, 0, maxHealth);
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    public bool IsDead()
    {
        return health <= 0;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health < 0)
            health = 0;
    }

    public void Heal(int amount)
    {
        health += amount;

        if (health > maxHealth)
            health = maxHealth;
    }

    public void Kill()
    {
        health = 0;
    }

    public void Revive()
    {
        health = maxHealth;
    }
}