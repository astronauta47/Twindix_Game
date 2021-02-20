using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarieraZ2 : MonoBehaviour {

    private Animator anim;
    public GameObject ściana;

    // Use this for initialization
    void Start()
    {
        anim = (Animator)ściana.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sphere" || other.gameObject.name == "Sphere2")
        {
            anim.SetTrigger("Zamknij2");
        }
        
    }
}
