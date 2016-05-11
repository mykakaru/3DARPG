using UnityEngine;
using System.Collections;

public class AniController : MonoBehaviour
{
    //public GameObject obj;
    Animator ani;           // 动画状态

    // 初始化动画对象
    void Start()
    {
        //obj = GameObject.Find("Player");
        ani = GetComponent<Animator>();
    }

    public void Stand()
    {
        ani.SetTrigger("Stand");
    }

    public void Move()
    {
        ani.SetTrigger("Move");
    }

    public void Atk1_1()
    {
        ani.SetTrigger("Attack1_1");
    }

    public void Atk1_2()
    {
        ani.SetTrigger("Attack1_2");
    }

    public void Hurt()
    {
        ani.SetTrigger("Hurt");
    }

    public void Stun()
    {
        ani.SetTrigger("Die");
    }

    public void Die()
    {
        ani.SetTrigger("Die");
    }


}
