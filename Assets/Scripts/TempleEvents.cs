using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TempleEvents : MonoBehaviour
{
    public static Action<Transform> transmit;   //位移委托，携带一个transform位置
    public static Action<int> figure;           //机关接触委托，携带机关编号
    public static Action rotate, pass;          //机关旋转和通过神殿委托，不需要参数
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
