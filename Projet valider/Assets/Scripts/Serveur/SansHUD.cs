using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.Networking.Match;
using UnityEngine.SceneManagement;
using System;

class RegisterHostMessage : MessageBase { public float message; }

public class SansHUD : NetworkManager
{
    public NetworkManager manager;
    public Scene sceneServeur;
    public Scene sceneClient;
    public static NetworkClient myclient;
    short messageID = 1000;
    short imageID = 1001;
    short conceptionID = 1002;
    short chronoID = 1003;
    public UnityEngine.UI.Text conText;
    public static short clientID = 123;
    public NetworkConnection id;
    public bool conceptionTerminee;
    public static int premierFini;
    public string Ip_serveur = "192.168.137.1"; // IP Table 192.168.43.40    192.168.1.10
    public static string spriteString;
    public static int[] positions = new int[] { 0, 0, 0, 0, 0, 0 };

    void Start()
    {
        conceptionTerminee = false;
        string ipv4 = IPManager.GetIP(IPManager.ADDRESSFAM.IPv4); // On met l'adresse IP de l'appareil courant dans ipv4
        Debug.Log(ipv4);
        if(ipv4 == Ip_serveur) 
        {
            manager.StartServer(); // Connection Serveur
            RegisterHandlers();
            Debug.Log("Serveur connecté");
        }
        else 
        {
            manager.StartClient(); // Connection Smartphone
            Debug.Log("client");
            myclient = new NetworkClient();
            myclient.Connect(Ip_serveur, 7777);
            SceneManager.LoadScene("scene1");
        } 
    }


    private void RegisterHandlers()
    {
        NetworkServer.RegisterHandler(MsgType.Connect, OnClientConnected);
        NetworkServer.RegisterHandler(messageID, OnMessageReceived);
        NetworkServer.RegisterHandler(imageID, onImageReceived);
        NetworkServer.RegisterHandler(conceptionID, onConceptionReceived);
        NetworkServer.RegisterHandler(1005, onTestReceived);
    }

    private void onTestReceived(NetworkMessage netMsg)
    {
        var v = netMsg.ReadMessage<MyImageMessage>();
        Debug.Log("position : " + v.image);
        Debug.Log("premier fini : " + v.type);
    }

    private void onConceptionReceived(NetworkMessage netMsg)
    {
        if (!conceptionTerminee)
        {
            premierFini = netMsg.ReadMessage<MyNetworkMessage>().message;
            Debug.Log("premier joueur : " + premierFini);
            EnAttenteCT.premierFini(premierFini);
            envoiChrono(premierFini);
            conceptionTerminee = true;
        }
        ConceptionTerminer.finiMaConception();
    }

    private void envoiChrono(int premierFini)
    {
        MyNetworkMessage message = new MyNetworkMessage();
        message.message = premierFini;
        NetworkServer.SendToAll(chronoID, message);
    }

    private void onImageReceived(NetworkMessage netMsg)
    {
        var objectMessage = netMsg.ReadMessage<MyImageMessage>();
        string imageString = objectMessage.image;
        string s = "";
        for (int i = 0; i < imageString.Length - 21; i++)
        {
            s = s + imageString[i];
        }
        Debug.Log(s);
        imageString = s;
        string imageType = objectMessage.type;
        spriteString = "image/" + imageType + "/" + imageString;
        Debug.Log(spriteString);
        Sprite imageSprite = Resources.Load<Sprite>(spriteString);
        Initialisation.get(imageSprite);
    }

    void OnMessageReceived(NetworkMessage message)
    {
        
        int id = message.ReadMessage<MyNetworkMessage>().message;
        Debug.Log("id_serveur : " + id);
        Text_Connexion.recupInfoJoueur(id);

        
    }

 


    public void OnCommandSent(NetworkMessage netMsg)
    {
        Debug.Log(netMsg);
    }


    ////////////////////       Partie Network     ///////////////////////////////////////


    public override void OnServerConnect(NetworkConnection conn)
    {
        NetworkServer.RegisterHandler(MsgType.Connect, OnClientConnected);
    }

    
   void OnClientConnected(NetworkMessage message)
    {
        Debug.Log("Client connecté");
    }
    

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        
        var player = (GameObject)GameObject.Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);

        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
        

        Debug.Log("Client has requested to get his player added to the game");

    }











    public override void OnServerDisconnect(NetworkConnection conn)
    {

        NetworkServer.DestroyPlayersForConnection(conn);

        if (conn.lastError != NetworkError.Ok)
        {

            if (LogFilter.logError) { Debug.LogError("ServerDisconnected due to error: " + conn.lastError); }

        }

        Debug.Log("A client disconnected from the server: " + conn);

    }

    public override void OnServerReady(NetworkConnection conn)
    {

        NetworkServer.SetClientReady(conn);

        Debug.Log("Client is set to the ready state (ready to receive state updates): " + conn);

    }


    

    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader)
    {
        Debug.Log("connexion établie");
    }

    public override void OnServerRemovePlayer(NetworkConnection conn, PlayerController player)
    {

        if (player.gameObject != null)

            NetworkServer.Destroy(player.gameObject);

    }

    public override void OnServerError(NetworkConnection conn, int errorCode)
    {

        Debug.Log("Server network error occurred: " + (NetworkError)errorCode);

    }

    public override void OnStartHost()
    {

        Debug.Log("Host has started");

    }

    public override void OnStartServer()
    {

        Debug.Log("Server has started");

    }

    public override void OnStopServer()
    {

        Debug.Log("Server has stopped");

    }

    public override void OnStopHost()
    {

        Debug.Log("Host has stopped");

    }

    // Client callbacks

    public override void OnClientConnect(NetworkConnection conn)

    {

        base.OnClientConnect(conn);

        Debug.Log("Connected successfully to server, now to set up other stuff for the client...");

    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {

        StopClient();

        if (conn.lastError != NetworkError.Ok)

        {

            if (LogFilter.logError) { Debug.LogError("ClientDisconnected due to error: " + conn.lastError); }

        }

        Debug.Log("Client disconnected from server: " + conn);

    }

    public override void OnClientError(NetworkConnection conn, int errorCode)
    {

        Debug.Log("Client network error occurred: " + (NetworkError)errorCode);

    }

    public override void OnClientNotReady(NetworkConnection conn)
    {

        Debug.Log("Server has set client to be not-ready (stop getting state updates)");

    }

    public override void OnStartClient(NetworkClient client)
    {

        Debug.Log("Client has started");

    }

    public override void OnStopClient()
    {

        Debug.Log("Client has stopped");

    }

    public override void OnClientSceneChanged(NetworkConnection conn)
    {

        base.OnClientSceneChanged(conn);

        Debug.Log("Server triggered scene change and we've done the same, do any extra work here for the client...");

    }



}




