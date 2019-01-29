using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_vert : MonoBehaviour
{

    public Sprite mainverte;

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
        
          this.gameObject.GetComponent<SpriteRenderer>().sprite = mainverte;
        
        
    }
}
