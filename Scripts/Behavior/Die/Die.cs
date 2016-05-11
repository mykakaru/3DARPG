using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour, IBehavior
{
    public GameObject obj;
    [HideInInspector]
    public PlayerManager pm;

    const int level = 50;
    bool dead = false;
    float aniTime = 240f;


    public int GetLevel()
    {
        return level;
    }

    public void Do()
    {
        if (!dead)
        {
            dead = true;
            DoDie();
        }
    }

    public void Over()
    {

    }

    void DoDie()
    {
        GetComponent<AniController>().Die();
        Destroy(gameObject, aniTime);
    }


}
