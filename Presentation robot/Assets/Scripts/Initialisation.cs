using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Main;

public class Initialisation : MonoBehaviour
{
    public int position;

    public GameObject J1carte1;
    public GameObject J1carte2;
    public GameObject J1carte3;
    public GameObject J1carte4;
    public GameObject J1carte5;

    public GameObject J2carte1;
    public GameObject J2carte2;
    public GameObject J2carte3;
    public GameObject J2carte4;
    public GameObject J2carte5;

    public GameObject J3carte1;
    public GameObject J3carte2;
    public GameObject J3carte3;
    public GameObject J3carte4;
    public GameObject J3carte5;

    public GameObject J4carte1;
    public GameObject J4carte2;
    public GameObject J4carte3;
    public GameObject J4carte4;
    public GameObject J4carte5;

    public GameObject J5carte1;
    public GameObject J5carte2;
    public GameObject J5carte3;
    public GameObject J5carte4;
    public GameObject J5carte5;

    public GameObject J6carte1;
    public GameObject J6carte2;
    public GameObject J6carte3;
    public GameObject J6carte4;
    public GameObject J6carte5;


    // Start is called before the first frame update
    void Start()
    {

        //Player p = Global.Player;
        
        switch (Global.Player.Place)
        {
            case 1:
                J1carte1.GetComponent<SpriteRenderer>().sprite = Global.TabD.getImageind(Global.Player.Idcarte2).Sprite;
                J1carte2.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte3).Sprite;
                J1carte3.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte4).Sprite;
                J1carte4.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte5).Sprite;
                J1carte5.GetComponent<SpriteRenderer>().sprite = Global.TabL.getImageind(Global.Player.Idcarte1).Sprite;
             break;
            
            case 2:
                J2carte1.GetComponent<SpriteRenderer>().sprite = Global.TabD.getImageind(Global.Player.Idcarte2).Sprite;
                J2carte2.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte3).Sprite;
                J2carte3.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte4).Sprite;
                J2carte4.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte5).Sprite;
                J2carte5.GetComponent<SpriteRenderer>().sprite = Global.TabL.getImageind(Global.Player.Idcarte1).Sprite;
                break;
            
            case 3:
                J3carte1.GetComponent<SpriteRenderer>().sprite = Global.TabD.getImageind(Global.Player.Idcarte2).Sprite;
                J3carte2.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte3).Sprite;
                J3carte3.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte4).Sprite;
                J3carte4.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte5).Sprite;
                J3carte5.GetComponent<SpriteRenderer>().sprite = Global.TabL.getImageind(Global.Player.Idcarte1).Sprite;
                break;
            
            case 4:
                J4carte1.GetComponent<SpriteRenderer>().sprite = Global.TabD.getImageind(Global.Player.Idcarte2).Sprite;
                J4carte2.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte3).Sprite;
                J4carte3.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte4).Sprite;
                J4carte4.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte5).Sprite;
                J4carte5.GetComponent<SpriteRenderer>().sprite = Global.TabL.getImageind(Global.Player.Idcarte1).Sprite;

                break;
            
            case 5:
                Debug.Log(Global.Player.Idcarte2);
                J5carte1.GetComponent<SpriteRenderer>().sprite = Global.TabD.getImageind(Global.Player.Idcarte2).Sprite;
                J5carte2.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte3).Sprite;
                J5carte3.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte4).Sprite;
                J5carte4.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte5).Sprite;
                J5carte5.GetComponent<SpriteRenderer>().sprite = Global.TabL.getImageind(Global.Player.Idcarte1).Sprite;
                break;
            
            case 6:
                J6carte1.GetComponent<SpriteRenderer>().sprite = Global.TabD.getImageind(Global.Player.Idcarte2).Sprite;
                J6carte2.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte3).Sprite;
                J6carte3.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte4).Sprite;
                J6carte4.GetComponent<SpriteRenderer>().sprite = Global.TabE.getImageind(Global.Player.Idcarte5).Sprite;
                J6carte5.GetComponent<SpriteRenderer>().sprite = Global.TabL.getImageind(Global.Player.Idcarte1).Sprite;
                break;
                
        }
        if (Global.Player.Place != 1)
        { 
            Destroy(J1carte1);
            Destroy(J1carte2);
            Destroy(J1carte3);
            Destroy(J1carte4);
            Destroy(J1carte5);
        }

        if (Global.Player.Place != 2)
        {
            Destroy(J2carte1);
            Destroy(J2carte2);
            Destroy(J2carte3);
            Destroy(J2carte4);
            Destroy(J2carte5);
        }

        if (Global.Player.Place != 3)
        {
            Destroy(J3carte1);
            Destroy(J3carte2);
            Destroy(J3carte3);
            Destroy(J3carte4);
            Destroy(J3carte5);
        }

        if (Global.Player.Place != 4)
        {
            Destroy(J4carte1);
            Destroy(J4carte2);
            Destroy(J4carte3);
            Destroy(J4carte4);
            Destroy(J4carte5);
        }

        if (Global.Player.Place != 5)
        {
            Destroy(J5carte1);
            Destroy(J5carte2);
            Destroy(J5carte3);
            Destroy(J5carte4);
            Destroy(J5carte5);
        }

        if (Global.Player.Place != 6)
        {
            Destroy(J6carte1);
            Destroy(J6carte2);
            Destroy(J6carte3);
            Destroy(J6carte4);
            Destroy(J6carte5);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
