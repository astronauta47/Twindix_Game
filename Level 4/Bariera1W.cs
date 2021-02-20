using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bariera1W : MonoBehaviour {

    public GameObject ściana;
    public GameObject wróg;
    private Animator anim;

    private void Start()
    {
        anim = (Animator)ściana.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider colizion)
    {
        if(colizion.gameObject == wróg)
        { anim.SetTrigger("Otwórz"); }
    }


}