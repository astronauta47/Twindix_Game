using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BonusoweLevele : MonoBehaviour {


    public string Level;
    public int point;
    public AudioSource audiosource;
    public AudioClip Audio;

    
    private void OnTriggerStay(Collider other)
    {
        
        if (Input.GetKey(KeyCode.Tab))
        {
            audiosource.PlayOneShot(Audio);
            

            if (PlayerPrefs.GetInt("Bon") == 2)
            {
                SceneManager.LoadScene(Level);
                Physics.gravity = new Vector3(0, -10, 0);
            }

        }
    }
}
