using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punkty : MonoBehaviour
{
    
    public GameObject czasteczki;
    public AudioSource audiosource;
    public AudioClip Audio;
    private int punkt = 0;

    void OnTriggerEnter(Collider collider)
    {
        

        if (collider.gameObject.name == "Sphere" || collider.gameObject.name == "Sphere2")
        {
            punkt = punkt + 1;
            audiosource.PlayOneShot(Audio);
            Instantiate(czasteczki, transform.position, Quaternion.identity);
            Destroy(gameObject,0.2f);
            
        }



}

}
