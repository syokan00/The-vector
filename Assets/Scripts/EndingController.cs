using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingController : MonoBehaviour
{
    public Image illustrationImage;      // 插图
    public Sprite[] illustrations;       // 插图数组
    public Text dialogueText;            // 对白文本
    public string[] dialogues;           // 对白数组
    private int index = 0;

    void Start()
    {
        ShowNext();
    }

    public void OnClickAnywhere()
    {
        ShowNext();
    }

    public void OnSkip()
    {
        SceneManager.LoadScene("CreditScene");
    }

    void ShowNext()
    {
        if (index < dialogues.Length)
        {
            dialogueText.text = dialogues[index];
            if (index < illustrations.Length)
                illustrationImage.sprite = illustrations[index];
            index++;
        }
        else
        {
            SceneManager.LoadScene("CreditScene");
        }
    }
}

