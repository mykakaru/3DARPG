using UnityEngine;
using System.Collections;

public class Hurt : MonoBehaviour, IBehavior
{
    public GameObject obj;
    public static float cd = 25.0f;
    [HideInInspector]
    public PlayerManager pm;

    const int level = 30;
    Clock clock = new Clock(cd);


    public int GetLevel()
    {
        return level;
    }

    public void Do()
    {
        if (!clock.GetState())
        {
            DoHurt();
        }
    }

    public void Over()
    {
        if (!clock.GetState())
        {
            pm.BehSet("stand");
        }
    }

    void DoHurt()
    {
        GetComponent<AniController>().Hurt();
    }
}
