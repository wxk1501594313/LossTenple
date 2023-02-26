using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleStates : MonoBehaviour
{
    static bool[] figured = new bool[2];
    public static void SetMachineState(int index)
    {
        if (index < 0 || index >= figured.Length) return; //�±�Խ�緵��
        figured[index] = true;
        foreach (bool f in figured) //figured����false�򷵻�(˵���л���δ�ƽ�)
            if (!f) return;
        if (TempleEvents.pass != null)//���ί�в�Ϊ��(��ί�а��˷���)���򷢲�ί��
            TempleEvents.pass();
    }
}
