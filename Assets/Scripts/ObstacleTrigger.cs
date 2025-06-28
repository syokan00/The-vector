using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleTrigger : MonoBehaviour
{
    public string gameOverScene = "GameOverScene1";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(gameOverScene); // ì≥è„è·äVÅCGame Over
        }
    }
}

