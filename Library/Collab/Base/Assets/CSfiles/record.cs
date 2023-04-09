/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class record : MonoBehaviour
{
    int[] recTime = new int[10000];
    int frameTime;
    int Rec_onoff;
    string[] uem = new string[100];
    public AudioSource source;
    public AudioClip[] note;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        frameTime = 0;
        Rec_onoff = 0; //default : record func turned off
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            recTime[i]++;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(i == 100)
                {
                    Rec_onoff = 0; //turn off!
                    i = 0;
                }
                else if(i<100)
                {
                    uem[i] = hit.transform.gameObject.tag;
                    Debug.Log("hit!");
                    i++;
                }
            }
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
                Debug.Log("Recorder turn off");
                Rec_onoff = 0; // turn off!
                i = 0;
        }
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Rec_onoff == 0)
            {
                Debug.Log("Recorder turn on");
                Rec_onoff = 1; // turn on!
            }
            else if(Rec_onoff == 1)
            {
                Debug.Log("Recorder turn off");
                Rec_onoff = 0; // turn off!
                i = 0;
            }
        }
        
        if(Rec_onoff == 1)
        {
            recTime[i]++;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(i == 100)
                {
                    Rec_onoff = 0; //turn off!
                    i = 0;
                }
                else if(i<100)
                {
                    uem[i] = hit.transform.gameObject.tag;
                    Debug.Log("hit!");
                    i++;
                }
            }

            if(Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("Recorder playing");
                if(frameTime < recTime[i])
                    frameTime++;
                else if(frameTime == recTime[i])
                {
                    if(uem[i] == "C1")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[0];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if(uem[i] == "C1#")
                    {
                        Debug.Log("Recorded C1#");
                        source.clip = note[1];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    frameTime = 0;
                    i++;
                }
            }
        }



    }
}
*/