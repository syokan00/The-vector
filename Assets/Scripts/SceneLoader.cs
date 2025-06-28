using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // 按钮点击后调用此函数
    public void LoadIntroScene()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
