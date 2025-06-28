using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1EventController : MonoBehaviour
{
    public Image sceneImage;
    public Text dialogueText;
    public Sprite[] sceneSprites; // 插图顺序
    public string[] dialogues;
    private int index = 0;
    private bool isTyping = false;
    private string currentLine = "";
    private float typeSpeed = 0.03f;

    void Start()
    {
        ShowNext();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) OnClick();
    }

    public void OnClick()
    {
        if (isTyping)
        {
            StopAllCoroutines();
            dialogueText.text = currentLine;
            isTyping = false;
        }
        else
        {
            ShowNext();
        }
    }

    void ShowNext()
    {
        if (index < dialogues.Length)
        {
            if (index < sceneSprites.Length)
                sceneImage.sprite = sceneSprites[index];
            currentLine = dialogues[index];
            StartCoroutine(TypeDialogue(currentLine));
            index++;
        }
        else
        {
            SceneManager.LoadScene("Stage2Scene");
        }
    }

    System.Collections.IEnumerator TypeDialogue(string line)
    {
        isTyping = true;
        dialogueText.text = "";
        foreach (char c in line)
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(typeSpeed);
        }
        isTyping = false;
    }

    public void OnSkip()
    {
        SceneManager.LoadScene("Stage2Scene");
    }
}
