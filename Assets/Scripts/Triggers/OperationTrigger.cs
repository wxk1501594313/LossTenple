using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationTrigger : MonoBehaviour
{
    //转轴操作在角色进入和离开操作区时改变内部的记录，然后在Update中根据记录判断按键再发布委托
    //不在OnTriggerStay中检测的原因是OnTriggerStay执行频率不够高，会出现检测不到按键按下的情况
    bool isArea;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") isArea = true;
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") isArea = false;
    }

    private void Update()
    {
        if (isArea && Input.GetKeyDown(KeyCode.J))
            TempleEvents.rotate?.Invoke();
    }
}
