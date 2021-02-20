using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Sterowanie3 : MonoBehaviour
{
    public int Prędkość = 7;
    public Canvas trzy;

    // Use this for initialization
    void Start()
    { 

        if (Trudnosc.PoziomTrudności2)
        {
            trzy.enabled = true;
        }
        else
        trzy.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();

        Vector3 nazwa = Vector3.zero;

        if (Input.GetKey(KeyCode.I))
        {
            nazwa = -Vector3.left;
        }

        if (Input.GetKey(KeyCode.K))
        {
            nazwa = Vector3.left;
        }

        if (Input.GetKey(KeyCode.L))
        {
            nazwa = -Vector3.forward;
        }

        if (Input.GetKey(KeyCode.J))
        {
            nazwa = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            nazwa = Vector3.up;
        }

        if (Input.GetKey(KeyCode.R))
        {
            string levelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(levelName);
        }


        rigidbody.AddTorque(nazwa * 30f);
        rigidbody.maxAngularVelocity = Prędkość;//zwiększanie maksymalnej prędkości

    }
}
