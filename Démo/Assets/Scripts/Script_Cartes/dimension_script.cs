using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dimension_script : MonoBehaviour
{

    public Sprite[] tableau;
    public static int nombre_equipement = 9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown()
    {
        int R = Random.Range(0, nombre_equipement);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = tableau[R];
    }
}

