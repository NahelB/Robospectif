using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class InitDebat : MonoBehaviour
{

    public Button button;
    private int JoueurCourant = SansHUD.premierFini;
    public GameObject perso0;
    public GameObject perso1;
    public GameObject perso2;
    public GameObject perso3;
    public GameObject perso4;
    public GameObject perso5;

    short persosID = 1007;

    private GameObject[] persos;
    private Sprite[] persoSprites;

    public static Sprite[] envoi;

    private int[] positions = Text_Connexion.envoi;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => ButtonClicked());

        persoSprites = new Sprite[6];
        persos = new GameObject[6];
        persos[0] = perso0;
        persos[1] = perso1;
        persos[2] = perso2;
        persos[3] = perso3;
        persos[4] = perso4;
        persos[5] = perso5;

        
        for (int i = 0; i < 6; i++)
        {
            persos[i].gameObject.SetActive(false);
        }
        NetworkServer.RegisterHandler(persosID, onPersoReceived);
        
    }

    private void ButtonClicked()
    {
        Debug.Log("yo");
        envoi = persoSprites;
        SceneManager.LoadScene("Scene_6");
    }

    private void onPersoReceived(NetworkMessage netMsg)
    {
        var v = netMsg.ReadMessage<MyPersoMessage>();
        int i = v.numero;
        string s = v.image;
        string spriteString = "image/Personnages/" + s;
        Sprite sp = Resources.Load<Sprite>(spriteString);
        for (int j = 0; j < 6; j++)
        {
            if ((positions[(2*j)+1] == i) && (positions[(2*j)+1] != JoueurCourant))
            {
                persoSprites[j] = sp;
                persos[j].transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = sp;
                persos[j].gameObject.SetActive(true);

            }
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
