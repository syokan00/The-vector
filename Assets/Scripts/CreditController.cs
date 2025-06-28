using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditController : MonoBehaviour
{
    public Text creditText;
    public float scrollSpeed = 30f;

    void Update()
    {
        creditText.transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
    }

    public void OnReturnToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void OnExitGame()
    {
        Application.Quit();
    }
}
