using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    


    //Vector3�� xyz���� ���� Ŭ���� �Լ�
    void Update()
    {
    // �� ������ ���� ȣ��
    //time.deltatime ������ ���� �ð� => ������ ���� �ð��� ���ϸ� ������ �ð� ������ ǥ���Ѵ�.
        this.gameObject.transform.position += new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime;
    }
}
