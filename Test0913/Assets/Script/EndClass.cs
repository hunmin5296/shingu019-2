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
            Debug.Log("��������");
        }
        if(love <= 70)
        {
            Debug.Log("���忣��");
        }

        //
        if(age >7 && age < 18)
        {
            Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�");
        }
        if (age < 13 || age > 70) //���̰� 13�̸� �Ǵ� || 70 �ʰ��� ���
        {
            Debug.Log("���� �� �� ���� �����Դϴ�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
