using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;       //角色
    public Transform rotateCube;   //转轴
    public GameObject[] lights;    //红灯
    public GameObject fence;       //围栏

    // Start is called before the first frame update
    void Start()
    {
        //改变角色位置
        TempleEvents.transmit += pos =>
        {
            player.position = pos.position;
            player.rotation = pos.rotation;
        };
        //设置状态并关闭红灯
        TempleEvents.figure += index =>
        {
            TempleStates.SetMachineState(index);
            lights[index].SetActive(false);
        };
        //将转轴旋转45度
        TempleEvents.rotate += () => rotateCube.Rotate(Vector3.up * 45, Space.Self);
        //关闭围栏
        TempleEvents.pass += () => fence.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
