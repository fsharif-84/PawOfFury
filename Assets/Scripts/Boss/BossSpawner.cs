using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject bossPrefab;
    public Transform spawnPoint;
    private bool bossSpawned = false;

    void Update()
    {
        Debug.Log("BossSpawner running. Instance = " + GameManager.Instance);
        if (!bossSpawned && GameManager.Instance.killCount >= 20)
        {
            SpawnBoss();
        }
    }

    void SpawnBoss()
    {
        Instantiate(bossPrefab, spawnPoint.position, Quaternion.identity);
        bossSpawned = true;
        Debug.Log("BOSS SPAWNED!");
    }
}
