using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour, IBehavior
{
    public GameObject obj;
    [HideInInspector]
    public PlayerManager pm;          // 创建一个状态机控制对象

    const int level = 10;               // 行为优先级

    public float defaultSpeed = 5f;     // 步行速度

    Vector3 movement;                   // 目标向量
    Rigidbody playerRigidbody;          // 玩家刚体对象
    int GroundMask;                     // 地面行走遮罩



    // 初始化函数
    void Awake()
    {
        //obj = gameObject;
        // 创建地面遮罩
        GroundMask = LayerMask.GetMask("Ground");

        // 抓取对象
        playerRigidbody = GetComponent<Rigidbody>();
    }


    public int GetLevel()
    {
        return level;
    }

    public void Do()
    {
        DoMove();
    }

    public void Over()
    {
        if (!Input.GetMouseButton(1))
        {
            pm.BehSet("stand");
        }
    }

    void DoMove()
    {
        Vector3 target;


        // 当鼠标右键且能够获取交点时执行移动
        if (Target.GetTarget(GroundMask, out target))
        {
            // 计算人物需要到达目标地的向量
            movement = target - transform.position;

            // 将高度变化固定为0
            movement.y = 0f;

            // 每秒按照速度行进
            movement = movement.normalized * Time.deltaTime;

            // 移动player位置
            playerRigidbody.MovePosition(transform.position + movement);

            // 根据获取到的向量执行朝向函数
            Turning(movement);
        }

        GetComponent<AniController>().Move();
    }


    // 人物朝向
    void Turning(Vector3 targetRotation)
    {
        Quaternion playerRotation = Quaternion.LookRotation(targetRotation);
        playerRigidbody.MoveRotation(playerRotation);
    }


}
