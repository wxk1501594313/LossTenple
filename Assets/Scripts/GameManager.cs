using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;       //��ɫ
    public Transform rotateCube;   //ת��
    public GameObject[] lights;    //���
    public GameObject fence;       //Χ��

    // Start is called before the first frame update
    void Start()
    {
        //�ı��ɫλ��
        TempleEvents.transmit += pos =>
        {
            player.position = pos.position;
            player.rotation = pos.rotation;
        };
        //����״̬���رպ��
        TempleEvents.figure += index =>
        {
            TempleStates.SetMachineState(index);
            lights[index].SetActive(false);
        };
        //��ת����ת45��
        TempleEvents.rotate += () => rotateCube.Rotate(Vector3.up * 45, Space.Self);
        //�ر�Χ��
        TempleEvents.pass += () => fence.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
