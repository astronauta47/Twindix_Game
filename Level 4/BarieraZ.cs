using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarieraZ : MonoBehaviour {

    private Animator anim;
    public GameObject ściana;

	// Use this for initialization
	void Start ()
    {
        anim = (Animator)ściana.GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("Zamknij");
    }
}
