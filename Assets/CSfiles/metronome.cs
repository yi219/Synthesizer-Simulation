using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metronome : MonoBehaviour
{
    public AudioSource source;
    public AudioClip note;
    float speed = 1.0f; //60
    bool token = true;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("metro").GetComponent<Light>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "metroButton")
                {
                    if (token == true) // turn on
                    {
                        GameObject.Find("metro").GetComponent<Light>().enabled = true;
                        //Debug.Log("turn on");
                        InvokeRepeating("soundFunction", 0.0f, speed);
                        token = false;
                    }
                    else// turn off
                    {
                        GameObject.Find("metro").GetComponent<Light>().enabled = false;
                        //Debug.Log("turn off");
                        CancelInvoke("soundFunction");
                        token = true;
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (token == true) // turn on
            {
                GameObject.Find("metro").GetComponent<Light>().enabled = true;
                //Debug.Log("turn on");
                InvokeRepeating("soundFunction", 0.0f, speed);
                token = false;
            }
            else// turn off
            {
                GameObject.Find("metro").GetComponent<Light>().enabled = false;
                //Debug.Log("turn off");
                CancelInvoke("soundFunction");
                token = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && speed >= 0.1f)
        {
            speed -= 0.1f;
            //Debug.Log("speed : " + speed);
            CancelInvoke("soundFunction");
            InvokeRepeating("soundFunction", 0.0f, speed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            speed += 0.1f;
            //Debug.Log("speed : " + speed);
            CancelInvoke("soundFunction");
            InvokeRepeating("soundFunction", 0.0f, speed);
        }

    }
    void soundFunction()
    {
        Debug.Log("metronome");
        source.clip = note;
        source.Play();
    }
}
