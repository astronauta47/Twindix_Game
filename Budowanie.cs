using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Budowanie : MonoBehaviour {

    public GameObject wentylator;
    public GameObject minusjeden;
    public GameObject minusdwa;
    public GameObject zero;

    public AudioSource audiosource;
    public AudioClip Audio;


    private void OnTriggerEnter(Collider other)
    {
        audiosource.PlayOneShot(Audio);

        if (wentylator.transform.position == minusdwa.transform.position)
        {
            wentylator.transform.position = minusjeden.transform.position;
        }
        else if(wentylator.transform.position == minusjeden.transform.position )
        {
            wentylator.transform.position = zero.transform.position;
        }
        else if(wentylator.transform.position == zero.transform.position)
        {
            wentylator.transform.position = minusdwa.transform.position;
        }

    }
}
