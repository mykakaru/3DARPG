using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour
{
    float curTime;
    float cd;
    bool state = false;
    
    
    public Clock(float cd)
    {
        this.cd = cd;
    }

    void Start()
    {
        curTime = 0.0f;
    }

    void FixedUpdate()
    {
        if (state)
        {
            curTime += Time.deltaTime;
            CDCheck(curTime);
        }
    }

    void CDCheck(float curTime)
    {
        if (curTime >= cd)
        {
            Off();
            curTime = 0.0f;
        }
    }

    public bool GetState()
    {
        return state;
    }

    public void On()
    {
        state = true;
    }

    public void Off()
    {
        state = false;
    }
}
