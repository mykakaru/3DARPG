using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour, IBehavior
{
    public GameObject obj;
    public static float cd = 75.0f;
    [HideInInspector]
    public PlayerManager pm;

    const int level = 20;
    Clock clock = new Clock(cd);


    public int GetLevel()
    {
        return level;
    }

    public void Do()
    {
        if (!clock.GetState())
        {
            DoAttack();
            clock.On();
        }
    }

    public void Over()
    {
        if (!clock.GetState())
        {
            pm.BehSet("stand");
        }
    }

    void DoAttack()
    {
        GetComponent<AniController>().Atk1_1();
    }
}
