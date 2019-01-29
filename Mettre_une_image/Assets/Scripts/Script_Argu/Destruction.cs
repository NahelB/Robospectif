using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject argu;

    public string BonhommeA;
    public string BonhommeB;


    void Start()
    {
        argu.SetActive(true);              
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == BonhommeA || coll.gameObject.name == BonhommeB)
        {
            argu.SetActive(false);
        }
            
    }

 
}
