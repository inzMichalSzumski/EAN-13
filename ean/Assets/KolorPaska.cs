using UnityEngine;
using System.Collections;

public class KolorPaska : MonoBehaviour
{

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();

    }

    void Update()
    {
        //ChangeColor(false);
    }

    public void ChangeColor(bool kolor)
    {
        if (kolor)
        {
            rend.material.color = Color.black;
        }

        if (!kolor)
        {
            rend.material.color = Color.white;
        } 
    }
}