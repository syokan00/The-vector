using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void Retry()
    {
        Time.timeScale = 1f; // 确保解除暂停
        SceneManager.LoadScene("Stage1Scene"); // 改成你的关卡名
    }

    public void BackToTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScene");
    }
}
