using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBot : MonoBehaviour {

    public GameObject Spherebot;
    public Transform Pozycja;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name != "LegoBox")
        {
            Instantiate(Spherebot, Pozycja.transform.position, Quaternion.identity);
        }
    }
}
