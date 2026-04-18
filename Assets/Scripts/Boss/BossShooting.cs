using UnityEngine;

public class BossShooting : MonoBehaviour
{
    public GameObject bossBulletPrefab;
    public float shootInterval = 1.5f;
    public float bulletSpeed = 6f;

    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        InvokeRepeating("ShootAtPlayer", 2f, shootInterval);
    }

    void ShootAtPlayer()
    {
        if (player == null) return;

        Vector2 direction = (player.position - transform.position).normalized;

        GameObject bullet = Instantiate(bossBulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().linearVelocity = direction * bulletSpeed;
    }
}
