using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroController : MonoBehaviour
{
    public Text dialogueText;
    public Image backgroundImage;
    public Sprite[] backgroundSprites;
    public string[] dialogues;
    public float typeSpeed = 0.03f;
    private int index = 0;
    private bool isTyping = false;
    private Coroutine typingCoroutine;

    void Start()
    {
        index = 0; // 确保每次进入都是从头开始
        ShowNextDialogue();
    }

    public void ShowNextDialogue()
    {
        if (index < dialogues.Length)
        {
            if (typingCoroutine != null)
                StopCoroutine(typingCoroutine);

            typingCoroutine = StartCoroutine(TypeDialogue(dialogues[index]));

            if (index < backgroundSprites.Length)
                backgroundImage.sprite = backgroundSprites[index];

            index++;
        }
        else
        {
            SceneManager.LoadScene("Stage1Scene"); // 播完跳转
        }
    }

    IEnumerator TypeDialogue(string line)
    {
        isTyping = true;
        dialogueText.text = "";
        foreach (char letter in line)
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
        isTyping = false;
    }

    public void OnClickAnywhere()
    {
        if (isTyping)
        {
            StopCoroutine(typingCoroutine);
            dialogueText.text = dialogues[index - 1]; // 补全当前句
            isTyping = false;
        }
        else
        {
            ShowNextDialogue();
        }
    }

    public void OnSkip()
    {
        SceneManager.LoadScene("Stage1Scene"); // 立即跳转
    }
}
