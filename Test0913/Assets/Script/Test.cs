using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        float distance = Getdistance(2, 2, 5, 6);   //�Լ��� ���ϰ��� distance ������ �Է�

        Debug.Log("(2,2)���� (5,6) ������ �Ÿ� :" + distance);  //����� �α׷� Ȯ���Ѵ�.
    }

    float Getdistance(float x1, float y1, float x2, float y2) //���� ���� �Ÿ��� ���ϴ� �Լ�
    { 
        float width = x1 - x1;                                //���� �Ÿ� ���ϱ�
        float height = y1 - y1;                                 //���� �Ÿ� ���ϱ�

        float distance = width * width + height * height;  //������ �������� ���Ѱ�
        distance = Mathf.Sqrt(distance);     //sqrt�� ��Ʈ�� ���

        return distance;

    }

}
