using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    // 按钮点击：重试
    public void OnRetry()
    {
        SceneManager.LoadScene("Stage1Scene");
    }

    // 按钮点击：返回标题
    public void OnReturnTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
