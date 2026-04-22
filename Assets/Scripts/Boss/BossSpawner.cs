using UnityEngine;
using UnityEngine.UI;

public class BossSpawner : MonoBehaviour
{
    public GameObject bossPrefab;
    public Transform spawnPoint;
    private bool bossSpawned = false;

    void Update()
    {
        if (!bossSpawned && GameManager.Instance.killCount >= 20)
        {
            SpawnBoss();
        }
    }

    public void SpawnBoss()
    {
        // Spawn the boss
        GameObject boss = Instantiate(bossPrefab, spawnPoint.position, Quaternion.identity);
        bossSpawned = true;
        Debug.Log("BOSS SPAWNED!");

        // Find the BossHealthBar slider in the scene
        Slider bossSlider = GameObject.Find("BossHealthBar").GetComponent<Slider>();

        // Assign the slider to the boss
        boss.GetComponent<BossHealth>().bossHealthBar = bossSlider;

        // Enable the UI
        bossSlider.gameObject.SetActive(true);
    }
}
