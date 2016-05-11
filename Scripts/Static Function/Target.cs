using UnityEngine;
using System.Collections;

public static class Target
{
    const float camRayLenth = 100f;       // 摄像机射线长度

    // 向地面发射一条射线，返回交点
    /// <summary>
    /// 判断是否有鼠标所指位置的坐标并返回该值
    /// </summary>
    /// <returns></returns>
    public static bool GetTarget(int targetMask, out Vector3 target)
    {
        // 从摄像机创建一条射线
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        // 创建接收交点用的对象
        RaycastHit targetHit;

        // 判断是否能够返回此交点，无法返回时则直接归零并返回错误
        if (Physics.Raycast(camRay, out targetHit, camRayLenth,targetMask))
        {
            target = targetHit.point;
            return true;
        }
        else
        {
            target = new Vector3(0,0,0);
            return false;
        }
    }
}
