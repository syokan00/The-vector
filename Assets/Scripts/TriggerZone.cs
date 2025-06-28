using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerZone : MonoBehaviour
{
    public string nextScene;  // 下一个要跳转的场景名字

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // 检查是否是玩家碰到了
        {
            SceneManager.LoadScene(nextScene);  // 跳转场景
        }
    }
}
