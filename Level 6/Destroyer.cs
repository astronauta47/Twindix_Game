using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject pulapka;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(pulapka);
    }
}
