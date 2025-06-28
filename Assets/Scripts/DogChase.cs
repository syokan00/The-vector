using UnityEngine;

public class DogChase : MonoBehaviour
{
    public Transform player;
    public float startSpeed = 2.5f;       // 起始速度（略小于玩家速度）
    public float maxSpeed = 3.5f;         // 最高速度
    public float acceleration = 0.1f;     // 每秒加速度

    private float currentSpeed;

    void Start()
    {
        currentSpeed = startSpeed;
    }

    void Update()
    {
        if (player != null)
        {
            // 逐渐加速
            currentSpeed = Mathf.Min(currentSpeed + acceleration * Time.deltaTime, maxSpeed);

            // 只追踪X轴
            Vector2 targetPosition = new Vector2(player.position.x, transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, currentSpeed * Time.deltaTime);
        }
    }
}


