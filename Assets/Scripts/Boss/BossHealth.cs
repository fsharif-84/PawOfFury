using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 150;
    public int currentHealth;

    public Slider bossHealthBar;

    void Start()
    {
        currentHealth = maxHealth;
        bossHealthBar.maxValue = maxHealth;
        bossHealthBar.value = currentHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0);

        bossHealthBar.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Boss defeated!");
        GameManager.Instance.enemyCount--;
        Destroy(gameObject);
    }
}
