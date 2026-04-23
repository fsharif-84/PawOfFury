using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public float fireRate = 0.2f;

    float nextFireTime = 0f;

    public AudioClip shootSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
{
    if (audioSource != null && shootSound != null)
        audioSource.PlayOneShot(shootSound);

    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector2 direction = (mousePos - transform.position).normalized;

    GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    bullet.GetComponent<PlayerBullet>().SetDirection(direction);
}

}
