using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Działo : MonoBehaviour
{

    public GameObject Blokada;

    private void OnTriggerEnter(Collider colision)
    {
        Destroy(Blokada);
    }
}