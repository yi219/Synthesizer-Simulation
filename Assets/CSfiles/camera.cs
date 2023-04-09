using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Camera mainCam;
    public Camera subCam;
    bool sub;
    public float Cspeed = 5.0f;
    public float scroll;


    // Start is called before the first frame update
    void Start()
    {
        mainCam.enabled = true;
        subCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (subCam.enabled)
            {
                mainCam.enabled = true;
                subCam.enabled = false;
            }
            else
            {
                subCam.enabled = true;
                mainCam.enabled = false;
            }
        }

        if (subCam.enabled == true)
        {
            scroll = Input.GetAxis("Mouse ScrollWheel") * Cspeed;
            if (scroll != 0)
            {
                subCam.transform.Translate(Vector3.forward * scroll);
            }
            if (Input.GetMouseButton(1))
            {
                subCam.transform.Rotate(0f, -Input.GetAxis("Mouse X") * Cspeed, 0f, 0f);
                subCam.transform.Rotate(Input.GetAxis("Mouse Y") * Cspeed, 0f, 0f);
            }
        }
    }
}