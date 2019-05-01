using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Terminer : MonoBehaviour
{

    public Button button;
    short waitID = 1006;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => ButtonClicked());
    }

    private void ButtonClicked()
    {
        MyNetworkMessage msg = new MyNetworkMessage();
        NetworkServer.SendToAll(waitID, msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
