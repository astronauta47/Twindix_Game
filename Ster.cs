using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ster : MonoBehaviour
{
    public int MaxPrędkość = 7;

    void Update()
    {

        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();

        Vector3 nazwa = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            nazwa = -Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            nazwa = Vector3.left;
        }

        if (Input.GetKey(KeyCode.W))
        {
            nazwa = -Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            nazwa = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            nazwa = Vector3.up;
        }



        if (Input.GetKey(KeyCode.R))
        {
            if (!Trudnosc.PoziomTrudności)
            {
                string levelName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(levelName);

                Physics.gravity = new Vector3(0, -10, 0);
            }

        }


        rigidbody.AddTorque(nazwa * 30f);
        rigidbody.maxAngularVelocity = MaxPrędkość;//zwiększanie maksymalnej prędkości

    }

}
