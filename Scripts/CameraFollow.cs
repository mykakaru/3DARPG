using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform target;            // 创建摄像机跟随焦点
    public float smoothing = 5f;        // 摄像机跟随速度

    Vector3 offset;                     // 偏移量

    // 初始化偏移量
    void Start()
    {
        // 得到摄像机与当前目标的固定位置偏移量
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // 求出摄像机的实时位置
        Vector3 targetCamPos = target.position + offset;

        // 平滑地将摄像机过渡到目标位置
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
