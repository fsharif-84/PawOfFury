using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    private Vector2 direction;

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

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
