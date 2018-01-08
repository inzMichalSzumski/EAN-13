using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class Generator : MonoBehaviour {

    public Button exit;

    public GameObject lewa;
    public GameObject prawa;
    SkryptLewej DoLewej;
    SkryptPrawej DoPrawej;
    public string kod;

    private GameObject inputFieldGo;
    private InputField inputFieldCo;

    // Use this for initialization
    void Start () {
        DoLewej = lewa.GetComponent<SkryptLewej>();
        DoPrawej = prawa.GetComponent<SkryptPrawej>();

        inputFieldGo = GameObject.Find("PoleTekstowy");
        inputFieldCo = inputFieldGo.GetComponent<InputField>();

        exit.onClick.AddListener(wyjscie);
    }
	
	// Update is called once per frame
	void Update () {
        //print(1f/Time.deltaTime);
        if (inputFieldCo.text.Length == 12)
        {
            Generowanie(inputFieldCo.text);
        }
    }

     void Generowanie(string kod) {

        int parzyste = 0;
        int nieparzyste = 0;
        string kontrolna;

        int i = 0;
        foreach (char element in kod)
        {

            if((i % 2) != 0)
            {
                nieparzyste = nieparzyste + (int)Char.GetNumericValue(element);
            }
            else
            {
                parzyste = parzyste + (int)Char.GetNumericValue(element);
            }
            i++;
        }


        kontrolna = (10 - (nieparzyste * 3 + parzyste) % 10).ToString();

        if (kontrolna.Equals("10"))
        {
            kontrolna = "0";
        }

        DoLewej.CiagDoSekwencjiL(kod.Substring(0, 7));
        DoPrawej.CiagDoSekwencjiP(kod.Substring(7, 5) + kontrolna);
    }

    void wyjscie()
    {
        Application.Quit();
    }
}
