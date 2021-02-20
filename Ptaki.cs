using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ptaki : MonoBehaviour
{

    private void Update()
    {
        if (Ptak() >= 4)
        {
            PlayerPrefs.SetInt("Bon",2);
        }
    }
    int Ptak()
    {
        Ptaki[] ptaszki = Component.FindObjectsOfType<Ptaki>();
        return ptaszki.Length;
    }
}