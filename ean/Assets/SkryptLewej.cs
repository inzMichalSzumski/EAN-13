using UnityEngine;
using System;
using System.Collections;

public class SkryptLewej : MonoBehaviour
{

    private string[] ukryta = { "000000",
                                "001011",
                                "001101",
                                "001110",
                                "010011",
                                "011001",
                                "011100",
                                "010101",
                                "010110",
                                "011010"};

    public GameObject lewa;
    private GameObject[] segment;
    private SkryptSegmentu[] wartosc;

    // Use this for initialization
    void Start()
    {

        segment = new GameObject[6];
        wartosc = new SkryptSegmentu[7];

        for (int i = 0; i < 6; i++)
        {
            segment[i] = lewa.transform.Find("segment" + (i + 1)).gameObject;
            wartosc[i] = segment[i].GetComponent<SkryptSegmentu>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CiagDoSekwencjiL(string ciag)
    {
        int pierwsza = IntParseFast(ciag.Substring(0, 1));
        string pierwsza2 = ukryta[pierwsza];

        int i = 0;
        ciag = ciag.Substring(1, 6);
        foreach (char element in ciag)
        {        
            wartosc[i].Sekwencja(IntParseFast(pierwsza2[i]), (int)Char.GetNumericValue(element));
            i++;
        }

    }

    public static int IntParseFast(char value)
    {
        int result = 0;
        result = 10 * result + (value - 48);
        return result;
    }

    public static int IntParseFast(string value)
    {
        int result = 0;
        for (int i = 0; i < value.Length; i++)
        {
            char letter = value[i];
            result = 10 * result + (letter - 48);
        }
        return result;
    }
}
