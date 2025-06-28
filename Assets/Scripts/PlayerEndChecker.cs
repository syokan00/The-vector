using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEndChecker : MonoBehaviour
{
    public float endX = 100f;
    public string nextScene = "Stage1EventScene";

    void Update()
    {
        if (transform.position.x >= endX)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
