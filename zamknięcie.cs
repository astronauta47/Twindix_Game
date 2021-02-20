using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zamknięcie : MonoBehaviour {

    public GameObject drzwi;
    public GameObject zapora;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(drzwi,transform.position, Quaternion.identity);
        Destroy(zapora);
    }
}
