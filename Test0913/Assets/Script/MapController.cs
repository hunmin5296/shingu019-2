using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
         public GameObject MapTile;
    // Start is called before the first frame update
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {

            for (int j = 0; j < 10; j++)
            {
                GameObject go = (GameObject)Instantiate(MapTile);
                go.transform.position = new Vector3(i, 0, j) + new Vector3(0.5f, 0, 0.5f);
            }
        }

    
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
