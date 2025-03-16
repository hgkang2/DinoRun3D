using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoFollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    void Start()
    {
        offset = target.position - transform.position;
    }

    void Update()
    {
        if(target != null)
        {
            Vector3 newCamPosition = new Vector3(transform.position.x,transform.position.y,target.position.z - offset.z);
            transform.position = newCamPosition;
        }
    }
}
