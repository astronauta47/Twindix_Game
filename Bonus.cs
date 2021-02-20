using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public TextMesh Rekord;
    public int pomocnik2;

    void Update()
    {
        pomocnik2 = PlayerPrefs.GetInt("Rekord");
        Rekord.text = pomocnik2.ToString();
       
        
    }
    

        
   
}
