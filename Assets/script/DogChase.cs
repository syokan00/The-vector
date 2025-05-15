using UnityEngine;

public class DogChase : MonoBehaviour
{
    public Transform player;  // 玩家（你）的位置
    public float speed = 2f;  // 追的速度

    void Update()
    {
        // 如果找到玩家，就往玩家方向移动
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            direction = direction.normalized;

            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
