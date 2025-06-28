using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;  // 玩家
    public Vector2 offset = new Vector2(0f, 0f); // 相机偏移
    public float smoothTime = 0.3f; // 跟随平滑度
    public Vector2 deadZone = new Vector2(1f, 1f); // 死区范围，玩家在这范围内移动不触发镜头

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 cameraPos = transform.position;
        Vector3 targetPos = target.position + (Vector3)offset;
        targetPos.z = cameraPos.z; // 保持 Z 不变

        Vector3 delta = targetPos - cameraPos;

        // 死区判断
        if (Mathf.Abs(delta.x) > deadZone.x)
        {
            cameraPos.x = Mathf.SmoothDamp(cameraPos.x, targetPos.x, ref velocity.x, smoothTime);
        }
        if (Mathf.Abs(delta.y) > deadZone.y)
        {
            cameraPos.y = Mathf.SmoothDamp(cameraPos.y, targetPos.y, ref velocity.y, smoothTime);
        }

        transform.position = cameraPos;
    }
}
