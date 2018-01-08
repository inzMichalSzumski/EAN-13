using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SkryptSegmentu : MonoBehaviour {

    //    private int[] A = {0001101, 0011001, 0010011, 0111101, 0100011, 0110001, 0101111, 0111011, 0110111, 0001011};
    //    private int[] B = {0100111, 0110011, 0011011, 0100001, 0011101, 0111001, 0000101, 0010001, 0001001, 0010111};
    //    private int[] C = {1110010, 1100110, 1101100, 1000010, 1011100, 1001110, 1010000, 1000100, 1001000, 1110100};

    //    private int [,] zbiory = { { 0001101, 0011001, 0010011, 0111101, 0100011, 0110001, 0101111, 0111011, 0110111, 0001011 },    //A
    //                              { 0100111, 0110011, 0011011, 0100001, 0011101, 0111001, 0000101, 0010001, 0001001, 0010111 },    //B
    //                               { 1110010, 1100110, 1101100, 1000010, 1011100, 1001110, 1010000, 1000100, 1001000, 1110100 } };  //C

   private string[,] zbiory = { { "0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011" },    //A
                               	{ "0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111" },    //B
                               	{ "1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100" } };  //C

    public GameObject segment;
    public Canvas cyfras;
    private Text cyfraSegmentu;
    private GameObject[] paski;
    private KolorPaska[] kolorpaska;



    // Use this for initialization
    void Start () {
        paski = new GameObject[7];
        kolorpaska = new KolorPaska[7];
        cyfraSegmentu = cyfras.GetComponent<Text>();

        for(int i = 0; i < 7; i++ ) {
            paski[i] = segment.transform.Find("pasek" + (i+1)).gameObject;
            kolorpaska[i] = paski[i].GetComponent<KolorPaska>();
        }        
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void Sekwencja(int zbior, int cyfra )
    {
        cyfraSegmentu.text = cyfra.ToString();
        string wartosc = zbiory[zbior, cyfra].ToString();
        //print(wartosc);
        int i = 0;
        foreach (char element in wartosc)
        {

            if (element.Equals('0'))
            {
                kolorpaska[i].ChangeColor(false);
            }
            if (element.Equals('1'))
            {
                kolorpaska[i].ChangeColor(true);
            }
            i++; 

        }
    }
}
