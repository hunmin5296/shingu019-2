using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{

    public int Gold = 1000; //public 은 인스펙터 창에서 확인을 지원해줌 
    // Start is called before the first frame update
    void Start()
    {
        //캐릭터 프로필 변수
        string characterName = "라라";    //문자열 characterName 선언하고 값 입력
        char bloodType = 'A';             //문자BloodType선언 & 값 입력
        int age = 17;                     //실수 나이값 선엄
        float height = 168.3f;            //높이값 선언
        bool isFemale = true;             // bool 값 선언

        Debug.Log("캐릭터 이름 :" + characterName);
        Debug.Log("혈액형 :" + bloodType);
        Debug.Log("나이 :" + age);
        Debug.Log("키 :" + height);
        Debug.Log("여성 :" + isFemale);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
