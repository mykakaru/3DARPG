using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{
    public GameObject obj;

    [HideInInspector]
    public IBehavior beh;
    [HideInInspector]
    public IBuff buff;
    [HideInInspector]
    public Stand stand;
    [HideInInspector]
    public Move move;
    [HideInInspector]
    public Hurt hurt;
    [HideInInspector]
    public Attack atk;
    [HideInInspector]
    public Die die;

    void Awake()
    {
        stand = obj.AddComponent<Stand>();
        move = obj.AddComponent<Move>();
        hurt = obj.AddComponent<Hurt>();
        atk = obj.AddComponent<Attack>();
        die = obj.AddComponent<Die>();

    }

    // 初始化控制脚本
    void Start()
    {
        stand.pm = this;
        move.pm = this;
        hurt.pm = this;
        atk.pm = this;
        die.pm = this;

        stand.obj = obj;
        move.obj = obj;
        hurt.obj = obj;
        atk.obj = obj;
        die.obj = obj;

        beh = stand;
    }

    // 每帧监测操作状态和优先级冲突
    void Update()
    {
        Detect();
        beh.Do();
        beh.Over();
    }

    void Detect()
    {
        if (Input.GetMouseButton(1) && move.GetLevel() > beh.GetLevel())
        {
            BehSet("move");
        }
        if (Input.GetMouseButtonDown(0) && atk.GetLevel() > beh.GetLevel())
        {
            BehSet("attack");
        }
    }

    public void BehSet(string beh)
    {
        switch (beh)
        {
            case "stand":
                this.beh = stand;
                break;
            case "move":
                this.beh = move;
                break;
            case "hurt":
                this.beh = hurt;
                break;
            case "attack":
                this.beh = atk;
                break;
            case "die":
                this.beh = die;
                break;
            default:
                Debug.Log("状态机强行设置时指向错误状态");
                break;
        }
    }
}
