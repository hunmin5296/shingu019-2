using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    


    //Vector3는 xyz값을 가진 클래스 함수
    void Update()
    {
    // 매 프레임 마다 호출
    //time.deltatime 프레임 간격 시간 => 프레임 간격 시간을 더하면 일정한 시간 간격을 표현한다.
        this.gameObject.transform.position += new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime;
    }
}
