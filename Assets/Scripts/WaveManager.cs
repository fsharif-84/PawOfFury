using UnityEngine;
using TMPro;

public class WaveManager : MonoBehaviour
{
    public EnemySpawner spawner;
    public TextMeshProUGUI waveText;
    public BossSpawner bossSpawner;

    public int currentWave = 1;

    void Update()
    {
        if (GameManager.Instance.enemyCount == 0)
        {
            StartNextWave();
        }
    }

    void StartNextWave()
    {
        if (currentWave == 1)
        {
            waveText.text = "Wave 1";
            spawner.enemySpeedMultiplier = 1f;
            spawner.SpawnWave(20);
        }
        else if (currentWave == 2)
        {
            waveText.text = "Wave 2";
            spawner.enemySpeedMultiplier = 1f;
            spawner.SpawnWave(20);
        }
        else if (currentWave == 3)
{
    waveText.text = "Boss Wave!";
    bossSpawner.SpawnBoss();

    spawner.enemySpeedMultiplier = 1.5f;

    // Enable endless spawning
    spawner.endlessMode = true;
}


        currentWave++;
    }
}
