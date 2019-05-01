using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class InitDebat : MonoBehaviour
{

    public GameObject perso0;
    public GameObject perso1;
    public GameObject perso2;
    public GameObject perso3;
    public GameObject perso4;
    public GameObject perso5;

    short persosID = 1007;

    private GameObject[] persos;

    private int[] positions;

    // Start is called before the first frame update
    void Start()
    {
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

    private void onPersoReceived(NetworkMessage netMsg)
    {
        var v = netMsg.ReadMessage<MyPersoMessage>();
        int i = v.numero;
        string s = v.image;
        string spriteString = "image/Personnages/" + s;
        Sprite sp = Resources.Load<Sprite>(spriteString);
        for (int j = 0; i < 6; j++)
        {
            /*if (positions[j] == i)
            {
                persos[i].transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = sp;
                persos[i].gameObject.SetActive(true);
            }*/
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
