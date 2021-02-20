using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WybórLevel : MonoBehaviour {

    public string Level;
    public AudioSource audiosource;
    public AudioClip Audio;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            audiosource.PlayOneShot(Audio);

            if (Trudnosc.PoziomTrudności)
            {
                SceneManager.LoadScene("Level 1");
                Physics.gravity = new Vector3(0, -10, 0);
            }
            
            else
            {
                SceneManager.LoadScene(Level);
                Physics.gravity = new Vector3(0, -10, 0);
            }
            

        }
    }
    }
