using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperationTrigger : MonoBehaviour
{
    //ת������ڽ�ɫ������뿪������ʱ�ı��ڲ��ļ�¼��Ȼ����Update�и��ݼ�¼�жϰ����ٷ���ί��
    //����OnTriggerStay�м���ԭ����OnTriggerStayִ��Ƶ�ʲ����ߣ�����ּ�ⲻ���������µ����
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
