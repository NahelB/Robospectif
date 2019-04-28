using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Attente : MonoBehaviour
{

    public Text text;
    short waitID = 1006;
    public static NetworkClient client = Valider.client;
    public static Joueur joueur = Valider.joueur;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Joueur : " + joueur.numero.ToString();
        client.RegisterHandler(waitID, onWaitReceived);
    }

    private void onWaitReceived(NetworkMessage netMsg)
    {
        SceneManager.LoadScene("scene3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
