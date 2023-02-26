using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleStates : MonoBehaviour
{
    static bool[] figured = new bool[2];
    public static void SetMachineState(int index)
    {
        if (index < 0 || index >= figured.Length) return; //下标越界返回
        figured[index] = true;
        foreach (bool f in figured) //figured中有false则返回(说明有机关未破解)
            if (!f) return;
        if (TempleEvents.pass != null)//如果委托不为空(即委托绑定了方法)，则发布委托
            TempleEvents.pass();
    }
}
