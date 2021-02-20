using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Sterowanie2 : MonoBehaviour
{
    public int MaxPrędkość = 7;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();

        Vector3 nazwa = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            nazwa = -Vector3.left;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            nazwa = Vector3.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            nazwa = -Vector3.forward;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
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
        rigidbody.maxAngularVelocity = MaxPrędkość;//zwiększanie maksymalnej prędkości

    }
}
