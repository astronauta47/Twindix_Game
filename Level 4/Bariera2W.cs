using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bariera2W : MonoBehaviour {

    public GameObject ściana;
    public GameObject wróg;
    public GameObject wróg2;
    private bool śmierć = false;
    private Animator anim;

    private void Start()
    {
        anim = (Animator)ściana.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider colizion)
    {
        if ((colizion.gameObject == wróg2 && śmierć )|| (colizion.gameObject == wróg && śmierć))
        { anim.SetTrigger("Otwórz2"); Destroy(wróg2); Destroy(wróg); }

        if(colizion.gameObject == wróg || colizion.gameObject == wróg2)
        { śmierć = true;  }
    }


}
