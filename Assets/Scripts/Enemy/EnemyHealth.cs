using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GameManager.Instance.AddKill();
        GameManager.Instance.enemyCount--;
        Destroy(gameObject);
    }
}
