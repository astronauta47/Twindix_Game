using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public TextMesh textMesh;
    public GameObject ptaszek;
    public string LevelName;

    void Start ()
    {
        textMesh.text = LevelName;

        

        if(PlayerPrefs.GetInt(LevelName + "_finished") == 0)
        {
            ptaszek.SetActive(false);
        }
	}

    
}
