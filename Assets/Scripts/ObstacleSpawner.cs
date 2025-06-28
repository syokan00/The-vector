using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float spawnInterval = 2f;
    public float spawnXOffset = 10f;
    public LayerMask groundLayer;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        Vector2 origin = new Vector2(player.position.x + spawnXOffset, player.position.y + 5f);

        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, 20f, groundLayer);
        if (hit.collider != null)
        {
            Vector3 spawnPos = new Vector3(origin.x, hit.point.y + 0.5f, 0f); // 高出地面一点
            int i = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[i], spawnPos, Quaternion.identity);
        }
    }
}


