using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manual : MonoBehaviour
{
    public GameObject obj;
    bool token = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if(token == true)
            {
                obj.transform.Translate(new Vector3(18.9f, 0, 0));
                token = false;
            }
            else
            {
                obj.transform.Translate(new Vector3(-18.9f, 0, 0));
                token = true;
            }
        }
        
    }
}
