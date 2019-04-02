using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Valider : MonoBehaviour
{
    public Button button;
    public Image loco;
    public Image dim;
    public Image equi0;
    public Image equi1;
    public Image equi2;
    public static int position;
    public static NetworkClient client = selectUser.client;
    short idMessage = 1001;
    short conceptionID = 1002;
    short chronoID = 1003;


    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => ButtonClicked());
        position = selectUser.positionEffective;
        client.RegisterHandler(chronoID, onChronoReceived);
    }

    private void onChronoReceived(NetworkMessage netMsg)
    {
        int joueurFini = netMsg.ReadMessage<MyNetworkMessage>().message;
        if (joueurFini != position)
        {
            ScriptTimer.debutChrono();
        }
    }

    private void ButtonClicked()
    {
        MyNetworkMessage conception = new MyNetworkMessage();
        conception.message = position;
        client.Send(conceptionID, conception);
        MyImageMessage test = new MyImageMessage();
        MyImageMessage mLoco = new MyImageMessage();
        //string s = UnityEditor.AssetDatabase.GetAssetPath(loco.sprite);
        mLoco.image= loco.sprite.ToString();
        mLoco.type = "Locomotion";
        MyImageMessage mDim = new MyImageMessage();
        mDim.image = dim.sprite.ToString() as string;
        mDim.type = "Dimension";
        MyImageMessage mEqui0 = new MyImageMessage();
        mEqui0.image = equi0.sprite.ToString() as string;
        mEqui0.type = "Equipements";
        MyImageMessage mEqui1 = new MyImageMessage();
        mEqui1.image = equi1.sprite.ToString() as string;
        mEqui1.type = "Equipements";
        MyImageMessage mEqui2 = new MyImageMessage();
        mEqui2.image = equi2.sprite.ToString() as string;
        mEqui2.type = "Equipements";
        client.Send(idMessage, mLoco);
        client.Send(idMessage, mDim);
        client.Send(idMessage, mEqui0);
        client.Send(idMessage, mEqui1);
        client.Send(idMessage, mEqui2);
        //if (position == SansHUD.premierFini) {
        //    MyImageMessage mLoco = new MyImageMessage();
        //    mLoco.image = loco.sprite.ToString();
        //    mLoco.type = "Locomotion";
        //    MyImageMessage mDim = new MyImageMessage();
        //    mDim.image = dim.sprite.ToString().ToString();
        //    mDim.type = "Dimension";
        //    MyImageMessage mEqui0 = new MyImageMessage();
        //    mEqui0.image = equi0.sprite.ToString().ToString();
        //    mEqui0.type = "Equipements";
        //    MyImageMessage mEqui1 = new MyImageMessage();
        //    mEqui1.image = equi1.sprite.ToString().ToString();
        //    mEqui1.type = "Equipements";
        //    MyImageMessage mEqui2 = new MyImageMessage();
        //    mEqui2.image = equi2.sprite.ToString().ToString();
        //    mEqui2.type = "Equipements";
        //    client.Send(idMessage, mLoco);
        //    client.Send(idMessage, mDim);
        //    client.Send(idMessage, mEqui0);
        //    client.Send(idMessage, mEqui1);
        //    client.Send(idMessage, mEqui2);
        //}        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
