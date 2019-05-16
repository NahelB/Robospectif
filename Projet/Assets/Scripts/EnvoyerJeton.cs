using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class EnvoyerJeton : MonoBehaviour
{
    public Text text;
    NetworkClient client = script_LogosEnvironnement.client;
    short jeton = 1010;
    public int position = selectUser.positionStatic;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Joueur : " + position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void envoyer()
    {
        MyJetonMessage msg = new MyJetonMessage();
        msg.joueur = position;
        string s = this.gameObject.GetComponent<Image>().sprite.ToString();
        string msgs = "";
        for (int i = 0; i < s.Length - 21; i++)
        {
            msgs = msgs + s[i];
        }
        msg.sprite = msgs;
        client.Send(jeton, msg);
    }
}
