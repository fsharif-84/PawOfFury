using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int killCount = 0;
    public int enemyCount = 0;

    void Awake()
    {
        Instance = this;
    }

    public void AddKill()
    {
        killCount++;
        Debug.Log("Kills: " + killCount);
    }

}
