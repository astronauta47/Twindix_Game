using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour {


    public Transform sphere;
    public Transform sphere2;

    void Update()
    {
        Vector3 vector = new Vector3(0, 5f, -8f);


        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();
        float prędkość = rigidbody.velocity.sqrMagnitude;

        Vector3 newPosicion = sphere.position + vector;

        vector = vector * (1f + prędkość / 150f);
        transform.position = Vector3.Lerp(transform.position, newPosicion, Time.deltaTime * 2f);

        if (sphere.position.y > 0)
        {
            transform.LookAt(sphere2);
        }
        if (sphere2.position.y > 0)
        {
            transform.LookAt(sphere);
        }

	}
}
