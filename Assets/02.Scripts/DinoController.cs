using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float turnSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        //앞으로 직진
        transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        //좌 우로 움직임
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-turnSpeed * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(turnSpeed * Time.deltaTime,0,0);
        }
    }
}
