using UnityEngine;

public class AlienPoliceAI : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    public float detectionRange = 20f;

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance < detectionRange)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
    }
}
