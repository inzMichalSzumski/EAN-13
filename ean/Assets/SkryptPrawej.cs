using UnityEngine;
using System;
using System.Collections;

public class SkryptPrawej : MonoBehaviour {

    public GameObject prawa;
    private GameObject[] segment;
    private SkryptSegmentu[] wartosc;

    // Use this for initialization
    void Start () {

        segment = new GameObject[6];
        wartosc = new SkryptSegmentu[7];

        for (int i = 0; i < 6; i++)
        {
            segment[i] = prawa.transform.Find("segment" + (i + 1)).gameObject;
            wartosc[i] = segment[i].GetComponent<SkryptSegmentu>();
        }
    }
	
	// Update is called once per frame
	void Update ()
    { 

	}

    public void CiagDoSekwencjiP(string ciag)
    {
        int i = 0;
        foreach (char element in ciag)
        {
            //print(Char.GetNumericValue(element));
            wartosc[i].Sekwencja(2, (int)Char.GetNumericValue(element));
            i++;
        }

    }
}
