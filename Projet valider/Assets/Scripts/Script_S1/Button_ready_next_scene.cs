using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Button_ready_next_scene : MonoBehaviour
{
    public Button Button_ready;
    private int[] positions;
    short positionsID = 1005;

    // Start is called before the first frame update
    void Start()
    {
        positions = new int[6];
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
        for (int i = 0; i <= 5; i++)
        {
            positions[i] = PlayerPrefs.GetInt("P" + (i + 1));     // Position des joueurs
        }
        for (int i =0; i < 6; i++)
        {
            Debug.Log("positions[" + i + "] = " + positions[i]);
        }
        MyPositionsMessage message = new MyPositionsMessage();
        message.position1 = positions[0];
        message.position2 = positions[1];
        message.position3 = positions[2];
        message.position4 = positions[3];
        message.position5 = positions[4];
        message.position6 = positions[5];
        NetworkServer.SendToAll(positionsID, message);

        // --------------------------

        // Debug.Log("Click");
        SceneManager.LoadScene("Scene_2");
    }
    
}
