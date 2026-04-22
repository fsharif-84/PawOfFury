using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage = 1;

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Enemy"))
    {
        other.GetComponent<EnemyHealth>().TakeDamage(damage);
        Destroy(gameObject);
    }

    if (other.CompareTag("Boss"))
    {
        other.GetComponent<BossHealth>().TakeDamage(damage);
        Destroy(gameObject);
    }
}

}
