using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Win :  MonoBehaviour {

    public string Wygrana;
    public int Point = 1;
    public int Moc;

    private void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.name == "Sphere" || colision.gameObject.name == "Sphere2")
        {
            string LevelName = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetInt(LevelName + "_finished", 1);

            if(LevelName == "Level 12" && Trudnosc.PoziomTrudności == true)
            {
                SceneManager.LoadScene("Win");
                PlayerPrefs.SetInt(Wygrana, 1);
            }
            
            if (!Trudnosc.PoziomTrudności)
            {
                SceneManager.LoadScene("menu");
                Physics.gravity = new Vector3(0, -10, 0); 
            }

             else if (Trudnosc.PoziomTrudności)
            {
                if (LevelName == "Level 1") { SceneManager.LoadScene("Level 2"); }
                if (LevelName == "Level 2") { SceneManager.LoadScene("Level 3"); }
                if (LevelName == "Level 3") { SceneManager.LoadScene("Level 4"); }
                if (LevelName == "Level 4") { SceneManager.LoadScene("Level 5"); }
                if (LevelName == "Level 5") { SceneManager.LoadScene("Level 6"); }
                if (LevelName == "Level 6") { SceneManager.LoadScene("Level 7"); }
                if (LevelName == "Level 7") { SceneManager.LoadScene("Level 8"); }
                if (LevelName == "Level 8") { SceneManager.LoadScene("Level 9"); }
                if (LevelName == "Level 9") { SceneManager.LoadScene("Level 10"); }
                if (LevelName == "Level 10") { SceneManager.LoadScene("Level 11"); }
                if (LevelName == "Level 11") { SceneManager.LoadScene("Level 12"); }
                if (LevelName == "Level 12") { SceneManager.LoadScene("Win"); }
            }
        }

    }
   
}
