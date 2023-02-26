using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    //传送点触发器有一个公开的位置，可以在Unity页面中配置，在角色进入时发布传送委托并传入位置 
    public Transform targetPose;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TempleEvents.transmit?.Invoke(targetPose);
        }
    }
}
