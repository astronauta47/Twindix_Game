using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licznik : MonoBehaviour {

    int Licz = 0;
    public GameObject sciana;
    public GameObject sciana2;
    public GameObject sciana3;
    public GameObject koniec;
    public GameObject Position;
    public GameObject Position2;
    public GameObject Point;

    private void OnTriggerEnter(Collider other)
    {
        Licz += 1;

        if(Licz == 17)
        {
            Destroy(sciana);
        }
        if (Licz == 20)
        {
            koniec.transform.position = Position.transform.position;
        }
        if (Licz == 30)
        {
            Destroy(sciana2);
            Destroy(sciana3);
            Instantiate(Point, Position2.transform.position, Quaternion.identity);
        }
    }
}
