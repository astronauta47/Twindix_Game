using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using UnityEngine;

public class StopAnim : MonoBehaviour
{
    public GameObject Box;
    public GameObject Miejsce;
    public int liczbaStrzalow = 5;

    private void OnTriggerEnter(Collider other)
    {

        for (int i = 0; i <= liczbaStrzalow; i++)
        {
            Instantiate(Box, Miejsce.transform.position, Quaternion.identity);
        }

           

    }
    
    




}
    