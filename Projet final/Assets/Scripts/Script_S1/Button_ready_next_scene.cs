using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_ready_next_scene : MonoBehaviour
{
    public Button Button_ready;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    void OnMouseDown()
    {
        // ----- PARTIE NATHAN -----
        // Envoies des positions
        for (int i = 1; i <= 6; i++)
        {
            PlayerPrefs.SetInt("P" + i, PlayerPrefs.GetInt("LaPosition" + i));    
        }
        // Envoies le nombre de joueur
        PlayerPrefs.SetInt("nombreJoueur", PlayerPrefs.GetInt("nbJoueur"));

        // --------------------------

        // Debug.Log("Click");
        SceneManager.LoadScene("Scene_2");
    }
    
}
