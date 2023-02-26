using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //��ɫ�˶��ŵ�FixUpdate�п�����Ч������������ײʱ�Ĳ���
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * Time.fixedDeltaTime * speed);
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * Time.fixedDeltaTime * speed);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * Time.fixedDeltaTime * speed);
        if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.down);
        if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up);
    }
}
