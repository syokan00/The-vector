using UnityEngine;

public class StoryReplayTrigger : MonoBehaviour
{
    public Animator storyAnimator;
    public string startStateName = "S__14229534"; // 替换成你的起始动画状态名

    void Start()
    {
        if (storyAnimator != null)
        {
            storyAnimator.Play(startStateName, 0, 0f); // 从头播放指定动画状态
        }
    }
}
