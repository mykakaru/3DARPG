using UnityEngine;
using System.Collections;

public interface IBuff
{
    int GetType();
    int GetLevel();
    void AddBuff();
    void Do();
    void Over();
}
