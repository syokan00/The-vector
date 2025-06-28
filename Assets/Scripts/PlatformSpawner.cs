using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform player;

    private float nextSpawnX = 0f;
    private float bufferDistance = 20f; // 玩家离平台尽头多少距离时生成新平台
    private GameObject lastPlatform;

    void Start()
    {
        SpawnFirstPlatform();
    }

    void Update()
    {
        // 当玩家快到达平台末尾时生成新平台
        if (player.position.x + bufferDistance > nextSpawnX)
        {
            SpawnNextPlatform();
        }
    }

    void SpawnFirstPlatform()
    {
        Vector3 spawnPos = new Vector3(0, 0, 0);
        lastPlatform = Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        nextSpawnX = GetPlatformEndX(lastPlatform);
    }

    void SpawnNextPlatform()
    {
        Vector3 spawnPos = new Vector3(nextSpawnX, 0, 0);
        lastPlatform = Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        nextSpawnX = GetPlatformEndX(lastPlatform);
    }

    float GetPlatformEndX(GameObject platform)
    {
        float width = platform.GetComponent<BoxCollider2D>().bounds.size.x;
        return platform.transform.position.x + width;
    }
}
