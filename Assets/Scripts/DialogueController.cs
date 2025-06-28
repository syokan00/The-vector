using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    [System.Serializable]
    public class DialogueData
    {
        public Sprite image;   // 对应图片
        [TextArea(2, 5)]
        public string text;    // 对应文字
    }

    public DialogueData[] dialogues;   // 一组对话数据
    public Image photoDisplay;         // UI：显示图片
    public Text dialogueText;          // UI：显示对白
    public Button nextButton;          // “下一句”按钮

    private int index = 0;

    void Start()
    {
        nextButton.onClick.AddListener(ShowNext);
        ShowCurrent();
    }

    void ShowCurrent()
    {
        if (index < dialogues.Length)
        {
            photoDisplay.sprite = dialogues[index].image;
            dialogueText.text = dialogues[index].text;
        }
        else
        {
            // 播放完毕 → 可以切换场景，或关闭UI
            gameObject.SetActive(false);
            // 或：SceneManager.LoadScene("NextScene");
        }
    }

    void ShowNext()
    {
        index++;
        ShowCurrent();
    }
}
