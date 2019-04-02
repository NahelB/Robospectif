using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class selectUser : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public static int positionEffective;
    private int isActive;
    public int i;
    public int position;
    public Text text;
    public Scene scene;
    private Main.Global g;
    public Main.Player player;
    public static NetworkClient client;
    public Scene sceneSuivante;
    short messageID = 1000;
    short positionsID = 1005;

    // public Text NumJoueur;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        // InvokeRepeating("requette", 1f, 1f);
        button.gameObject.SetActive(false);
        client = SansHUD.myclient;
        client.RegisterHandler(positionsID, OnPositionsReceived);
    }

    private void OnPositionsReceived(NetworkMessage netMsg)
    {
        var message = netMsg.ReadMessage<MyPositionsMessage>();
        switch (position)
        {
            case 1:
                isActive = message.position1;
                break;
            case 2:
                isActive = message.position2;
                break;
            case 3:
                isActive = message.position3;
                break;
            case 4:
                isActive = message.position4;
                break;
            case 5:
                isActive = message.position5;
                break;
            case 6:
                isActive = message.position6;
                break;
        }
        if (isActive != 0)
        {
            button.gameObject.SetActive(true);
            text.text = isActive.ToString();
            positionEffective = isActive;
        }
    }

    void ButtonClicked(int i)
    {
        //position = i;
        Debug.Log(" i " + i);
        //Output this to console when the Button3 is clicked
        Main.Global.Player = new Main.Player(i);
        Debug.Log(" ID " + Main.Global.Player.Id);
        MyNetworkMessage message = new MyNetworkMessage();
        message.message = Main.Global.Player.Id;
        client.Send(messageID, message);
        PlayerPrefs.SetInt("idplayer", Main.Global.Player.Id);
        //StartCoroutine(selectPlayer(i));
        SceneManager.LoadScene("scene2");
        Debug.Log(i);
    }

    IEnumerator selectPlayer(int i)
    {
        WWWForm form = new WWWForm();
        form.AddField("id",i);
        WWW www = new WWW("https://primsie-spears.000webhostapp.com/estSelect.php",form);
        yield return www;
    }
    
    private void requette()
    {
        button.onClick.AddListener(() => ButtonClicked(i));
    }

    void OnMessageReceived(NetworkMessage message)
    {
        var test = message.ReadMessage<MyNetworkMessage>();
        Debug.Log("Message : " + test);
    }


}

