using UnityEngine;
using System.Collections;

public interface IBehavior
{
    int GetLevel();
    void Do();
    void Over();
}
