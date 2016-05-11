using UnityEngine;
using System.Collections;

public class GroundMaskFollow : MonoBehaviour
{
    public Transform followTarget;          // 创建跟随主体

    void Start()
    {

    }

    // 保证每帧都会让地面遮罩跟随目标
    void FixedUpdate()
    {
        transform.position = followTarget.position;
    }
}
