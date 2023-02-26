using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineTrigger : MonoBehaviour
{
    //机关触发器，在unity页面配置公开编号，并在机关破解时发布机关破解委托
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "machineTrigger")
            TempleEvents.figure?.Invoke(index);
    }
}
