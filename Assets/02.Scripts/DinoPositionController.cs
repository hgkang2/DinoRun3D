using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoPositionController : MonoBehaviour
{
    public float radius = 1f;
    public float ratio = 0.1f;

    void Update()
    {
        SetDinoPosition();
    }

    private void SetDinoPosition()
    {
        //360도를 개수로 나눠 증가되는 각도를 구한다.
        float anglesStep = 360f / (transform.childCount * ratio);
        for (int i = 0; i < transform.childCount; i++)
        {
            //각 오브젝트의 배치 각도 계산
            float angle = i * anglesStep;
            //각도를 라디안으로 바꿔줘야함
            float angleRad = Mathf.Deg2Rad * angle;
            //x와 z좌표를 원형으로 계산해야 함
            float x = Mathf.Cos(angleRad) * radius;
            float z = Mathf.Sin(angleRad) * radius;
            //새로운 위치로 자식 오브젝트를 위치시킴
            transform.GetChild(i).localPosition = new Vector3(x, 0, z);
        }
    }
}
