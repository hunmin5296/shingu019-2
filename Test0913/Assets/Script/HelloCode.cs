using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{

    public int Gold = 1000; //public �� �ν����� â���� Ȯ���� �������� 
    // Start is called before the first frame update
    void Start()
    {
        //ĳ���� ������ ����
        string characterName = "���";    //���ڿ� characterName �����ϰ� �� �Է�
        char bloodType = 'A';             //����BloodType���� & �� �Է�
        int age = 17;                     //�Ǽ� ���̰� ����
        float height = 168.3f;            //���̰� ����
        bool isFemale = true;             // bool �� ����

        Debug.Log("ĳ���� �̸� :" + characterName);
        Debug.Log("������ :" + bloodType);
        Debug.Log("���� :" + age);
        Debug.Log("Ű :" + height);
        Debug.Log("���� :" + isFemale);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
