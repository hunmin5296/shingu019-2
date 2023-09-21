using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndClass : MonoBehaviour
{

     public int love = 100;
    public int age = 20;
    // Start is called before the first frame update
    void Start()
    {
        if(love > 70)
        {
            Debug.Log("좋은엔딩");
        }
        if(love <= 70)
        {
            Debug.Log("베드엔딩");
        }

        //
        if(age >7 && age < 18)
        {
            Debug.Log("의무 교욱을 받고 있습니다");
        }
        if (age < 13 || age > 70) //나이가 13미만 또는 || 70 초과일 경우
        {
            Debug.Log("일을 할 수 없는 나이입니다");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
