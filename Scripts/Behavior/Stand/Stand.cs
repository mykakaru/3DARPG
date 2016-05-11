using UnityEngine;
using System.Collections;

public class Stand : MonoBehaviour, IBehavior
{
    public GameObject obj;
    [HideInInspector]
    public PlayerManager pm;

    const int level = 0;

    
    public int GetLevel()
    {
        return level;
    }

    public void Do()
    {
        DoStand();
    }

    public void Over()
    {

    }

    void DoStand()
    {
        obj.GetComponent<AniController>().Stand();
    }


}