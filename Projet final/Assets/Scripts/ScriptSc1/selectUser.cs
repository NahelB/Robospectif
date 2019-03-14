using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class selectUser : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public int i;
    public Scene scene;
    private Main.Global g;
    public Main.Player player;
    NetworkClient client;
    short messageID = 1000;

    // public Text NumJoueur;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        // InvokeRepeating("requette", 1f, 1f);
        button.onClick.AddListener(() => ButtonClicked(i));
        client = new NetworkClient();
        client.RegisterHandler(messageID, OnMessageReceived);
        client.Connect("192.168.43.40", 7777);
    }    
    
    void ButtonClicked(int i)
    {
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

