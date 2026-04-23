using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1;

    public AudioClip deathSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
        //Play death sound
        if (audioSource != null && deathSound != null)
            audioSource.PlayOneShot(deathSound);

        GameManager.Instance.AddKill();
        GameManager.Instance.enemyCount--;

        //Destroy enemy after sound plays
        Destroy(gameObject, 0.2f);
    }
}
