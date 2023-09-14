using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        float distance = Getdistance(2, 2, 5, 6);   //함수의 리턴값을 distance 변수에 입력

        Debug.Log("(2,2)에서 (5,6) 까지의 거리 :" + distance);  //디버그 로그로 확인한다.
    }

    float Getdistance(float x1, float y1, float x2, float y2) //두점 사이 거리를 구하는 함수
    { 
        float width = x1 - x1;                                //가로 거리 구하기
        float height = y1 - y1;                                 //세로 거리 구하기

        float distance = width * width + height * height;  //각각의 제곱근을 더한값
        distance = Mathf.Sqrt(distance);     //sqrt는 루트를 씌운값

        return distance;

    }

}
