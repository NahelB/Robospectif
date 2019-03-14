using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Main;

public class Initialisation : MonoBehaviour
{
    public int position;

    public GameObject carte1;
    public GameObject carte2;
    public GameObject carte3;
    public GameObject carte4;
    public GameObject carte5;


    // Start is called before the first frame update
    void Start()
    {

        Player p = Global.Player;
        Sprite monsprite = Resources.Load<Sprite>("image/Locomotion/Ailes");
        carte1.GetComponent<SpriteRenderer>().sprite = Global.TabL.getImageind(1).Sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
