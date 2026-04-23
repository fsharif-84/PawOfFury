using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject bossPrefab;
    public Transform spawnPoint;

    public AudioClip bossSpawnSound;
    public AudioSource audioSource;

    public void SpawnBoss()
    {
        Instantiate(bossPrefab, spawnPoint.position, Quaternion.identity);
        Debug.Log("BOSS SPAWNED!");

        if (audioSource != null && bossSpawnSound != null)
        {
            audioSource.PlayOneShot(bossSpawnSound);
        }
    }
}
