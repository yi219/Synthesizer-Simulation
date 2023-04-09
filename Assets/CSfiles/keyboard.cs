using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard : MonoBehaviour
{
    public AudioSource source;
    public GameObject[] obj;
    public AudioClip[] note;
    public int current_octave;
    public int n_index;
    public int count;
    public static float vol;
    public int i, j;
    public bool[] C1 = new bool[21];
    public bool[] B = new bool[15];
    
    // Start is called before the first frame update
    void Start()
    {
        current_octave = 3; //range : 2~4
        vol = 0.8F;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (current_octave != 2)
                current_octave--;
            OneOctavePlay(current_octave);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (current_octave != 4)
                current_octave++;
            OneOctavePlay(current_octave);
        }

        else //when not changing octave
        {
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                Debug.Log("MINUS");
                vol -= 0.1F;
            }

            else if (Input.GetKeyDown(KeyCode.Equals))
            {
                Debug.Log("PLUS");
                vol += 0.1F;
            }

            OneOctavePlay(current_octave);
        }
    }

    void OneOctavePlay(int octave) //func playing one Octave >_<
    {
        if (octave == 2)
            n_index = 0;
        else if (octave == 3)
            n_index = 12;
        else if (octave == 4)
            n_index = 24;

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("C");
            source.clip = note[n_index + 0];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                C1[0] = true;
                obj[0].transform.Rotate(0, 0, -3);
                count = obj[0].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[0].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 3)
            {
                C1[7] = true;
                obj[7].transform.Rotate(0, 0, -3);
                count = obj[7].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[7].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 4)
            {
                C1[14] = true;
                obj[14].transform.Rotate(0, 0, -3);
                count = obj[14].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[14].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("C#");
            source.clip = note[n_index + 1];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                B[0] = true;
                GameObject.Find("C#1").transform.Rotate(0, 0, -3);
                GameObject.Find("C#1").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 3)
            {
                B[5] = true;
                GameObject.Find("C#2").transform.Rotate(0, 0, -3);
                GameObject.Find("C#2").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 4)
            {
                B[10] = true;
                GameObject.Find("C#3").transform.Rotate(0, 0, -3);
                GameObject.Find("C#3").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("D");
            source.clip = note[n_index + 2];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                C1[1] = true;
                obj[1].transform.Rotate(0, 0, -3);
                count = obj[1].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[1].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 3)
            {
                C1[8] = true;
                obj[8].transform.Rotate(0, 0, -3);
                count = obj[8].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[8].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 4)
            {
                C1[15] = true;
                obj[15].transform.Rotate(0, 0, -3);
                count = obj[15].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[15].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("D#");
            source.clip = note[n_index + 3];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                B[1] = true;
                GameObject.Find("D#1").transform.Rotate(0, 0, -3);
                GameObject.Find("D#1").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 3)
            {
                B[6] = true;
                GameObject.Find("D#2").transform.Rotate(0, 0, -3);
                GameObject.Find("D#2").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 4)
            {
                B[11] = true;
                GameObject.Find("D#3").transform.Rotate(0, 0, -3);
                GameObject.Find("D#3").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("E");
            source.clip = note[n_index + 4];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                C1[2] = true;
                obj[2].transform.Rotate(0, 0, -3);
                count = obj[2].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[2].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 3)
            {
                C1[9] = true;
                obj[9].transform.Rotate(0, 0, -3);
                count = obj[9].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[9].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 4)
            {
                C1[16] = true;
                obj[16].transform.Rotate(0, 0, -3);
                count = obj[16].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[16].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F");
            source.clip = note[n_index + 5];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                C1[3] = true;
                obj[3].transform.Rotate(0, 0, -3);
                count = obj[3].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[3].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 3)
            {
                C1[10] = true;
                obj[10].transform.Rotate(0, 0, -3);
                count = obj[10].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[10].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 4)
            {
                C1[17] = true;
                obj[17].transform.Rotate(0, 0, -3);
                count = obj[17].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[17].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("F#");
            source.clip = note[n_index + 6];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                B[2] = true;
                GameObject.Find("F#1").transform.Rotate(0, 0, -3);
                GameObject.Find("F#1").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 3)
            {
                B[7] = true;
                GameObject.Find("F#2").transform.Rotate(0, 0, -3);
                GameObject.Find("F#2").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 4)
            {
                B[12] = true;
                GameObject.Find("F#3").transform.Rotate(0, 0, -3);
                GameObject.Find("F#3").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("G");
            source.clip = note[n_index + 7];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                C1[4] = true;
                obj[4].transform.Rotate(0, 0, -3);
                count = obj[4].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[4].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 3)
            {
                C1[11] = true;
                obj[11].transform.Rotate(0, 0, -3);
                count = obj[11].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[11].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 4)
            {
                C1[18] = true;
                obj[18].transform.Rotate(0, 0, -3);
                count = obj[18].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[18].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("G#");
            source.clip = note[n_index + 8];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                B[3] = true;
                GameObject.Find("G#1").transform.Rotate(0, 0, -3);
                GameObject.Find("G#1").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 3)
            {
                B[5] = true;
                GameObject.Find("G#2").transform.Rotate(0, 0, -3);
                GameObject.Find("G#2").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 4)
            {
                B[10] = true;
                GameObject.Find("G#3").transform.Rotate(0, 0, -3);
                GameObject.Find("G#3").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("A");
            source.clip = note[n_index + 9];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                C1[5] = true;
                obj[5].transform.Rotate(0, 0, -3);
                count = obj[5].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[5].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 3)
            {
                C1[12] = true;
                obj[12].transform.Rotate(0, 0, -3);
                count = obj[12].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[12].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 4)
            {
                C1[19] = true;
                obj[19].transform.Rotate(0, 0, -3);
                count = obj[19].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[19].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            Debug.Log("A#");
            source.clip = note[n_index + 10];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                B[4] = true;
                GameObject.Find("A#1").transform.Rotate(0, 0, -3);
                GameObject.Find("A#1").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 3)
            {
                B[9] = true;
                GameObject.Find("A#2").transform.Rotate(0, 0, -3);
                GameObject.Find("A#2").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
            else if (current_octave == 4)
            {
                B[14] = true;
                GameObject.Find("A#3").transform.Rotate(0, 0, -3);
                GameObject.Find("A#3").transform.GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("B");
            source.clip = note[n_index + 11];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                C1[6] = true;
                obj[6].transform.Rotate(0, 0, -3);
                count = obj[6].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[6].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 3)
            {
                C1[13] = true;
                obj[13].transform.Rotate(0, 0, -3);
                count = obj[13].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[13].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 4)
            {
                C1[20] = true;
                obj[20].transform.Rotate(0, 0, -3);
                count = obj[20].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[20].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("C");
            source.clip = note[n_index + 12];
            source.PlayOneShot(source.clip, vol);
            if (current_octave == 2)
            {
                C1[7] = true;
                obj[7].transform.Rotate(0, 0, -3);
                count = obj[7].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[7].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
            if (current_octave == 3)
            {
                C1[14] = true;
                obj[14].transform.Rotate(0, 0, -3);
                count = obj[14].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[14].transform.GetChild(i).GetComponent<Renderer>().material.color = new Color(255 / 255f, 255 / 255f, 50 / 255f);
                }
            }
        }




        if (Input.GetKeyUp(KeyCode.A))
        {
            if (current_octave == 2)
            {
                C1[0] = true;
                obj[0].transform.Rotate(0, 0, 3);
                count = obj[0].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[0].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 3)
            {
                C1[7] = true;
                obj[7].transform.Rotate(0, 0, 3);
                count = obj[7].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[7].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 4)
            {
                C1[14] = true;
                obj[14].transform.Rotate(0, 0, 3);
                count = obj[14].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[14].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (current_octave == 2)
            {
                B[0] = true;
                GameObject.Find("C#1").transform.Rotate(0, 0, 3);
                GameObject.Find("C#1").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 3)
            {
                B[5] = true;
                GameObject.Find("C#2").transform.Rotate(0, 0, 3);
                GameObject.Find("C#2").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 4)
            {
                B[10] = true;
                GameObject.Find("C#3").transform.Rotate(0, 0, 3);
                GameObject.Find("C#3").transform.GetComponent<Renderer>().material.color = Color.black;
            }
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (current_octave == 2)
            {
                C1[1] = true;
                obj[1].transform.Rotate(0, 0, 3);
                count = obj[1].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[1].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 3)
            {
                C1[8] = true;
                obj[8].transform.Rotate(0, 0, 3);
                count = obj[8].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[8].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 4)
            {
                C1[15] = true;
                obj[15].transform.Rotate(0, 0, 3);
                count = obj[15].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[15].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (current_octave == 2)
            {
                B[1] = true;
                GameObject.Find("D#1").transform.Rotate(0, 0, 3);
                GameObject.Find("D#1").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 3)
            {
                B[6] = true;
                GameObject.Find("D#2").transform.Rotate(0, 0, 3);
                GameObject.Find("D#2").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 4)
            {
                B[11] = true;
                GameObject.Find("D#3").transform.Rotate(0, 0, 3);
                GameObject.Find("D#3").transform.GetComponent<Renderer>().material.color = Color.black;
            }
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (current_octave == 2)
            {
                C1[2] = true;
                obj[2].transform.Rotate(0, 0, 3);
                count = obj[2].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[2].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 3)
            {
                C1[9] = true;
                obj[9].transform.Rotate(0, 0, 3);
                count = obj[9].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[9].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 4)
            {
                C1[16] = true;
                obj[16].transform.Rotate(0, 0, 3);
                count = obj[16].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[16].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            if (current_octave == 2)
            {
                C1[3] = true;
                obj[3].transform.Rotate(0, 0, 3);
                count = obj[3].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[3].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 3)
            {
                C1[10] = true;
                obj[10].transform.Rotate(0, 0, 3);
                count = obj[10].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[10].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 4)
            {
                C1[17] = true;
                obj[17].transform.Rotate(0, 0, 3);
                count = obj[17].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[17].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            if (current_octave == 2)
            {
                B[2] = true;
                GameObject.Find("F#1").transform.Rotate(0, 0, 3);
                GameObject.Find("F#1").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 3)
            {
                B[7] = true;
                GameObject.Find("F#2").transform.Rotate(0, 0, 3);
                GameObject.Find("F#2").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 4)
            {
                B[12] = true;
                GameObject.Find("F#3").transform.Rotate(0, 0, 3);
                GameObject.Find("F#3").transform.GetComponent<Renderer>().material.color = Color.black;
            }
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            if (current_octave == 2)
            {
                C1[4] = true;
                obj[4].transform.Rotate(0, 0, 3);
                count = obj[4].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[4].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 3)
            {
                C1[11] = true;
                obj[11].transform.Rotate(0, 0, 3);
                count = obj[11].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[11].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 4)
            {
                C1[18] = true;
                obj[18].transform.Rotate(0, 0, 3);
                count = obj[18].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[18].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            if (current_octave == 2)
            {
                B[3] = true;
                GameObject.Find("G#1").transform.Rotate(0, 0, 3);
                GameObject.Find("G#1").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 3)
            {
                B[5] = true;
                GameObject.Find("G#2").transform.Rotate(0, 0, 3);
                GameObject.Find("G#2").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 4)
            {
                B[10] = true;
                GameObject.Find("G#3").transform.Rotate(0, 0, 3);
                GameObject.Find("G#3").transform.GetComponent<Renderer>().material.color = Color.black;
            }
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            if (current_octave == 2)
            {
                C1[5] = true;
                obj[5].transform.Rotate(0, 0, 3);
                count = obj[5].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[5].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 3)
            {
                C1[12] = true;
                obj[12].transform.Rotate(0, 0, 3);
                count = obj[12].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[12].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 4)
            {
                C1[19] = true;
                obj[19].transform.Rotate(0, 0, 3);
                count = obj[19].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[19].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            if (current_octave == 2)
            {
                B[4] = true;
                GameObject.Find("A#1").transform.Rotate(0, 0, 3);
                GameObject.Find("A#1").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 3)
            {
                B[9] = true;
                GameObject.Find("A#2").transform.Rotate(0, 0, 3);
                GameObject.Find("A#2").transform.GetComponent<Renderer>().material.color = Color.black;
            }
            else if (current_octave == 4)
            {
                B[14] = true;
                GameObject.Find("A#3").transform.Rotate(0, 0, 3);
                GameObject.Find("A#3").transform.GetComponent<Renderer>().material.color = Color.black;
            }
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            if (current_octave == 2)
            {
                C1[6] = true;
                obj[6].transform.Rotate(0, 0, 3);
                count = obj[6].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[6].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 3)
            {
                C1[13] = true;
                obj[13].transform.Rotate(0, 0, 3);
                count = obj[13].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[13].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 4)
            {
                C1[20] = true;
                obj[20].transform.Rotate(0, 0, 3);
                count = obj[20].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[20].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            if (current_octave == 2)
            {
                C1[7] = true;
                obj[7].transform.Rotate(0, 0, 3);
                count = obj[7].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[7].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
            if (current_octave == 3)
            {
                C1[14] = true;
                obj[14].transform.Rotate(0, 0, 3);
                count = obj[14].transform.childCount;
                for (i = 0; i < count; i++)
                {
                    obj[14].transform.GetChild(i).GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
        //if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S)) || Input.GetKeyUp(KeyCode.D)||){

        //}
    }
}
