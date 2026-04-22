using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthBar;
    public int maxHealth = 10;
    public int currentHealth;

    void Start()
{
    currentHealth = maxHealth;
    healthBar.maxValue = maxHealth;
    healthBar.value = currentHealth;
}

public void TakeDamage(int damage)
{
    currentHealth -= damage;
    currentHealth = Mathf.Max(currentHealth, 0);

    healthBar.value = currentHealth;

    Debug.Log("Player Health: " + currentHealth);

    if (currentHealth <= 0)
    {
        Die();
    }
}



void Die()
{
    Debug.Log("Player died!");
    gameObject.SetActive(false);
}

}

