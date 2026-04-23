using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 150;
    public int currentHealth;

    private Slider bossHealthBar;

    public AudioClip hitSound;
    private AudioSource audioSource;

    void Start()
    {
        currentHealth = maxHealth;

        bossHealthBar = GameObject.Find("BossHealthBar").GetComponent<Slider>();
        bossHealthBar.maxValue = maxHealth;
        bossHealthBar.value = currentHealth;
        audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;

        bossHealthBar.value = currentHealth;

        audioSource.PlayOneShot(hitSound);

        if (currentHealth == 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Boss defeated!");
        FindObjectOfType<EnemySpawner>().endlessMode = false;
        Destroy(gameObject);
    }
}
