using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineTrigger : MonoBehaviour
{
    //���ش���������unityҳ�����ù�����ţ����ڻ����ƽ�ʱ���������ƽ�ί��
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "machineTrigger")
            TempleEvents.figure?.Invoke(index);
    }
}
