using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rec : MonoBehaviour
{
    int[] recTime = new int[1000000];
    int frameTime;
    int Rec_onoff;
    int onoff;
    bool record;
    string[] uem = new string[100000];
    public AudioSource source;
    public AudioClip[] note;
    int u;
    int i;
    bool playcom;
    int playu;
    bool play;
    int current_octave;

    // Start is called before the first frame update
    void Start()
    {
        frameTime = 0;
        Rec_onoff = 0; //default : record func turned off
        record = false; //녹음된 곡이 있는가
        i = 0;
        u = 0;  //note
        playu = 0;  //재생된 note 
        playcom = false; //한 음이 재생되었는지
        play = false;
        current_octave = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (current_octave != 2)
                current_octave--;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (current_octave != 4)
                current_octave++;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Rec_onoff == 0)
            {
                Debug.Log("Recorder turn on");
                record = true;
                for(i=0;i<1000000; i++)
                {
                    recTime[i] = 0;
                }
                for (i = 0; i < 100000; i++)
                {
                    uem[i] = null;
                }

                Rec_onoff = 1;
            }
            else if (Rec_onoff == 1)
            {
                Debug.Log("Recorder turn off");
                Rec_onoff = 0; // turn off!
            }
        }

        if (Rec_onoff == 1)  //녹음 진행 중
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("clicked");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    u++;
                    uem[u] = hit.transform.gameObject.tag;
                    Debug.Log("hit!");
                }
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "C1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "C2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "C3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "C#1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "C#2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "C#3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "D1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "D2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "D3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "D#1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "D#2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "D#3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "E1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "E2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "E3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "F1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "F2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "F3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "F#1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "F#2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "F#3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "G1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "G2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "G3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.Y))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "G#1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "G#2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "G#3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.H)) 
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "A1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "A2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "A3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.U))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "A#1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "A#2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "A#3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.J))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "B1";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "B2";
                }
                else if (current_octave == 4)
                {
                    u++;
                    uem[u] = "B3";
                }
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                if (current_octave == 2)
                {
                    u++;
                    uem[u] = "C2";
                }
                else if (current_octave == 3)
                {
                    u++;
                    uem[u] = "C3";
                }
            }

            recTime[u]++;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            play = true;
            playu = 0;
        }

        if (record == true && play == true)
        {
            Debug.Log("Recorder playing");
            if (uem[1] == "C1") { Debug.Log("1note C1"); }
            if (uem[2] == "C#1") { Debug.Log("2note C#1"); }
            if(uem[3]=="C1") { Debug.Log("3note C1"); }

            if (frameTime != recTime[playu])
            {
                if (playcom == false)
                {
                    if (uem[playu] == "C1")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[0];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "C#1")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[1];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "D1")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[2];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "D#1")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[3];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "E1")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[4];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "F1")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[5];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "F#1")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[6];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "G1")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[7];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "G#1")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[8];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "A1")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[9];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "A#1")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[10];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "B1")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[11];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "C2")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[12];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "C#2")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[13];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "D2")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[14];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "D#2")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[15];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "E2")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[16];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "F2")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[17];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "F#2")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[18];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "G2")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[19];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "G#2")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[20];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "A2")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[21];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "A#2")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[22];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "B2")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[23];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "C3")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[24];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "C#3")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[25];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "D3")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[26];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "D#3")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[27];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "E3")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[28];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "F3")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[29];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "F#3")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[30];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "G3")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[31];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "G#3")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[32];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "A3")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[33];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "A#3")
                    {
                        Debug.Log("Recorded C1");
                        source.clip = note[34];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    else if (uem[playu] == "B3")
                    {
                        Debug.Log("Recorded C#1");
                        source.clip = note[35];
                        source.PlayOneShot(source.clip, 1.0F);
                    }
                    playcom = true;
                }
                frameTime++;
            }
            else
            {
                frameTime = 0;
                playu++;
                playcom = false;
            }
            if(playu == (u+1))
            {
                play = false;
            }
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

*/

    }
}
