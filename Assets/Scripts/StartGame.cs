using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string gameSceneName = "GameScene"; // 这里是默认值，可以在 Inspector 修改

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene(gameSceneName); // 用变量代替写死的字符串
    }
}
