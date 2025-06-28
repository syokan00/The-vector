using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PictureStoryController2 : MonoBehaviour
{
    public Image backgroundImage;       // 用于显示插图
    public Sprite[] storyImages;        // 插图数组
    private int index = 0;

    void Start()
    {
        ShowNextImage();  // 显示第一张图
    }

    public void ShowNextImage()
    {
        if (index < storyImages.Length)
        {
            backgroundImage.sprite = storyImages[index];
            index++;
        }
        else
        {
            // 播完所有图后跳转关卡（可以改为你自己的关卡名）
            SceneManager.LoadScene("CreditScene");
        }
    }

    public void OnClickAnywhere()
    {
        ShowNextImage();  // 点击后切换图
    }
}