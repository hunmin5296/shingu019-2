using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime); // 앞으로 forward 만큼 이동한다
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(-Vector3.forward * Time.deltaTime); // 뒤로 이동
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.transform.eulerAngles += new Vector3(0.0f, 30.0f, 0.0f) *Time.deltaTime; // 앞으로 forward 만큼 이동한다
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.eulerAngles -= new Vector3(0.0f, 30.0f, 0.0f) * Time.deltaTime; // 앞으로 forward 만큼 이동한다
        }
    }
}
