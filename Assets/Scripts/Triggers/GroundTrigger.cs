using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    //���͵㴥������һ��������λ�ã�������Unityҳ�������ã��ڽ�ɫ����ʱ��������ί�в�����λ�� 
    public Transform targetPose;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TempleEvents.transmit?.Invoke(targetPose);
        }
    }
}
