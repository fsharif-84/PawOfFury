using UnityEngine;

public class ShrinkManager : MonoBehaviour
{
    public Transform topBorder;
    public Transform bottomBorder;
    public Transform leftBorder;
    public Transform rightBorder;

    public float shrinkDistance = 1f;   // how much each side moves inward
    public float shrinkInterval = 300f; // 300 seconds = 5 minutes

    void Start()
    {
        InvokeRepeating(nameof(ShrinkOnce), shrinkInterval, shrinkInterval);
    }

    void ShrinkOnce()
    {
        topBorder.position += Vector3.down * shrinkDistance;
        bottomBorder.position += Vector3.up * shrinkDistance;
        leftBorder.position += Vector3.right * shrinkDistance;
        rightBorder.position += Vector3.left * shrinkDistance;
    }
}