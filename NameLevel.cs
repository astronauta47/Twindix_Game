using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NameLevel : MonoBehaviour
{

    public TextMesh nazwa;

    void Start ()
    {
        nazwa.text = SceneManager.GetActiveScene().name;
        
    }
	
	
}
