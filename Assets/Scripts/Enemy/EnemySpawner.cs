using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float enemySpeedMultiplier = 1f;
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public bool endlessMode = false;

    public void SpawnWave(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, spawnPoints.Length);

            //Spawn one enemy
            var enemy = Instantiate(enemyPrefab, spawnPoints[index].position, Quaternion.identity);

            //Apply speed if enabled
            enemy.GetComponent<EnemyFollow>().speed *= enemySpeedMultiplier;

            //Count enemy
            GameManager.Instance.enemyCount++;
        }
    }
}
