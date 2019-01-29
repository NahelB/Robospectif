using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_personnage : MonoBehaviour
{
    public Sprite[] tableau;
    public static int nombre_personnage = 6;
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
        int R = Random.Range(0, nombre_personnage);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = tableau[R];
    }
}
