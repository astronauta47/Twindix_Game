using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrzejściePoziomów2 : MonoBehaviour
{

    Animator anim;
    public GameObject kamera;
    private Vector3 position;
    private Vector3 position2;

    private void Start()
    {
        anim = (Animator)kamera.GetComponent<Animator>();
        position = new Vector3(0, 1, -10);
        position2 = new Vector3(0, 27, -10);
    }

    public void OnTriggerEnter(Collider other2)
    {
        if (other2.gameObject.name == "Sphere" || other2.gameObject.name == "Sphere2")
        {

            //////////////////////////////////////////////////////////////////
            if (kamera.transform.position != position2)
            { anim.SetTrigger("lewo"); }


            if (kamera.transform.position == position2)
            { anim.SetTrigger("prawo"); }
        }
    }

}
