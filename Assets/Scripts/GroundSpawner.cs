using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundPrefab;     // 地面预制体
    public Transform player;            // 主角
    public float groundLength = 20f;    // 每块地面长度
    public int maxGrounds = 5;          // 一开始生成几块地面
    public float groundheight = 1.5501f;

    private float nextSpawnX = 0f;

    void Start()
    {
        // 初始生成 maxGrounds 块地面
        for (int i = 0; i < maxGrounds; i++)
        {
            SpawnGround();
        }
    }

    void Update()
    {
        // 主角快接近地面尽头时生成新地面
        if (player.position.x + (groundLength * 2) > nextSpawnX)
        {
            SpawnGround();
        }
    }

    void SpawnGround()
    {
        Vector3 spawnPos = new Vector3(nextSpawnX,groundheight, 0);
        Instantiate(groundPrefab, spawnPos, Quaternion.identity);
        nextSpawnX += groundLength;
    }
}
