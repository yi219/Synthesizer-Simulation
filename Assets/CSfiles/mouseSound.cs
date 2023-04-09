using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseSound : MonoBehaviour
{
    public GameObject[] obj;
    bool S;
    public AudioSource source;
    public AudioClip[] note;
    public int current_octave;
    public int n_index;
    public int count;
    public int i, j;
    public GameObject clicked;
    public bool[] C1 = new bool[21];


    // Start is called before the first frame update
    void Start()
    {
        //current_octave = 2; //range : 2~4
        keyboard.vol = 0.8F;
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetKeyDown(KeyCode.LeftArrow))
         {
             if (current_octave != 2)
                 current_octave--;
             mousePlay(current_octave);
         }

         else if (Input.GetKeyDown(KeyCode.RightArrow))
         {
             if (current_octave != 4)
                 current_octave++;
             mousePlay(current_octave);
         }

         else //when default(3octave) or when not changing octave
         {
             mousePlay(current_octave);
         }
        */
        mousePlay();
    }

    void mousePlay()
    {
        n_index = 0;


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "VolUp")
                {
                    Debug.Log("VolUp");
                    keyboard.vol += 0.1F;
                }
                if (hit.transform.gameObject.tag == "VolDown")
                {
                    Debug.Log("VolDown");
                    keyboard.vol -= 0.1F;
                }
                if (hit.transform.gameObject.tag == "C1")
                {
                    C1[0] = true;
                    obj[0].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 0];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[0].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[0].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //GameObject[] test = GameObject.FindGameObjectsWithTag("C1");
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "C#1")
                {
                    S = true;
                    //obj[1].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 1];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;

                }
                else if (hit.transform.gameObject.tag == "D1")
                {
                    C1[1] = true;
                    obj[1].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 2];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[1].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[1].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "D#1")
                {
                    S = true;
                    //obj[3].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 3];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "E1")
                {
                    C1[2] = true;
                    obj[2].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 4];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[2].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[2].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "F1")
                {
                    C1[3] = true;
                    obj[3].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 5];
                    //source.PlayOneShot(source.clip, 1.0F);
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[3].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[3].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "F#1")
                {
                    //obj[6].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 6];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "G1")
                {
                    C1[4] = true;
                    obj[4].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 7];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[4].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[4].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "G#1")
                {
                    //obj[8].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 8];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "A1")
                {
                    C1[5] = true;
                    obj[5].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 9];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[5].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[5].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "A#1")
                {
                    //obj[10].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 10];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "B1")
                {
                    C1[6] = true;
                    obj[6].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 11];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[6].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[6].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "C2")
                {
                    C1[7] = true;
                    obj[7].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 12];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[7].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[7].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "C#2")
                {
                    //obj[13].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 13];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "D2")
                {
                    C1[8] = true;
                    obj[8].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 14];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[8].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[8].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "D#2")
                {
                    //obj[15].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 15];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "E2")
                {
                    C1[9] = true;
                    obj[9].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 16];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[9].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[9].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "F2")
                {
                    C1[10] = true;
                    obj[10].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 17];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[10].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[10].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "F#2")
                {
                    //obj[18].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 18];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "G2")
                {
                    C1[11] = true;
                    obj[11].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 19];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[11].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[11].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "G#2")
                {
                    //obj[20].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 20];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "A2")
                {
                    C1[12] = true;
                    obj[12].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 21];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[12].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[12].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "A#2")
                {
                    //obj[22].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 22];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "B2")
                {
                    C1[13] = true;
                    obj[13].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 23];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[13].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[13].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "C3")
                {
                    C1[14] = true;
                    obj[14].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 24];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[14].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[14].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "C#3")
                {
                    //obj[25].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 25];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "D3")
                {
                    C1[15] = true;
                    obj[15].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 26];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[15].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[15].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "D#3")
                {
                    //obj[27].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 27];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "E3")
                {
                    C1[16] = true;
                    obj[16].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 28];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[16].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[16].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "F3")
                {
                    C1[17] = true;
                    obj[17].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 29];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[17].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[17].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "F#3")
                {
                    //obj[30].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 30];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "G3")
                {
                    C1[18] = true;
                    obj[18].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 31];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[18].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[18].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "G#3")
                {
                    //obj[32].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 32];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "A3")
                {
                    C1[19] = true;
                    obj[19].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 33];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[19].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[19].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "A#3")
                {
                    //obj[34].transform.Rotate(0, 0, -3);
                    S = true;
                    source.clip = note[n_index + 34];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    hit.transform.Rotate(0, 0, -3);
                    hit.transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    clicked = hit.transform.gameObject;
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }
                else if (hit.transform.gameObject.tag == "B3")
                {
                    C1[20] = true;
                    obj[20].transform.Rotate(0, 0, -3);
                    source.clip = note[n_index + 35];
                    source.PlayOneShot(source.clip, keyboard.vol);
                    count = obj[20].transform.childCount;
                    for (i = 0; i < count; i++)
                    {
                        obj[20].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                    }
                    //hit.transform.Rotate(new Vector3(0, rotSpeed, 0));
                }

                Debug.Log(hit.transform.gameObject);
            }

        }
        if (Input.GetMouseButtonUp(0))
        {
            for (i = 0; i < 21; i++)
            {
                if (C1[i] == true)
                {
                    obj[i].transform.Rotate(0, 0, 3);
                    count = obj[i].transform.childCount;
                    for (j = 0; j < count; j++)
                    {
                        obj[i].transform.GetChild(j).GetComponent<Renderer>().material.color = Color.white;
                    }
                    C1[i] = false;
                }
            }
            if (S == true)
            {
                clicked.transform.Rotate(0, 0, 3);
                clicked.transform.GetComponent<Renderer>().material.color = Color.black;
                S = false;
            }
            Debug.Log("Up!");

        }
    }
}