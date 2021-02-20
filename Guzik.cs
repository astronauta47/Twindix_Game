using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guzik : MonoBehaviour {

    int klucz1 = 0;
    int klucz2 = 0;
    public GameObject Platforma;
    public GameObject Pozycja;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Sphere")
        {
            klucz1 = 1;
            Debug.Log("1");
        }

        if (other.gameObject.name == "Sphere2")
        {
            klucz2 = 2;
            Debug.Log("2");
        }

        if(klucz1 == 1 && klucz2 == 2)
        {
            Debug.Log("3");
            Platforma.transform.position = Pozycja.transform.position;
        }
    }
}
