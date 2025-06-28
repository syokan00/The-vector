using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationEndHandler : MonoBehaviour
{
    public string nextSceneName = "Stage1Scene"; // 你要跳转的场景名

    public void OnAnimationFinished()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
