using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrzejściePoziomów : MonoBehaviour {

    Animator anim;
    public GameObject kamera;
    private Vector3 position;
    private Vector3 position2;

    private void Start()
    {
        anim = (Animator)kamera.GetComponent<Animator>();
        position = new Vector3(0, 2, -10);
        position2 = new Vector3(0, 27, -10);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere" || other.gameObject.name == "Sphere2")
        {
            if (kamera.transform.position != position)
            { anim.SetTrigger("MenuPowrót"); }

            if (kamera.transform.position == position)
            { anim.SetTrigger("Menu"); }

           
        }
    }

}
