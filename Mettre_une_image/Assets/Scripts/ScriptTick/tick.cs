using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class tick : MonoBehaviour
{

    public GameObject dimension;
    public GameObject locomotion;
    public GameObject equipement1;
    public GameObject equipement2;
    public GameObject equipement3;
    public GameObject locker;
    public GameObject hourglass;
    public Sprite dosDimension;
    public Sprite dosLocomotion;
    public Sprite dosEquipement;
    public Sprite lockerVert;
    public Sprite hourglassSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if ((dimension.GetComponent<SpriteRenderer>().sprite != dosDimension) && (locomotion.GetComponent<SpriteRenderer>().sprite != dosLocomotion) && (equipement1.GetComponent<SpriteRenderer>().sprite != dosEquipement) && (equipement2.GetComponent<SpriteRenderer>().sprite != dosEquipement) && (equipement3.GetComponent<SpriteRenderer>().sprite != dosEquipement))
        {
            locker.GetComponent<SpriteRenderer>().sprite = lockerVert;
            if (hourglass.GetComponent<SpriteRenderer>().sprite != hourglassSprite)
            {
                hourglass.GetComponent<SpriteRenderer>().sprite = hourglassSprite;
            }
        }
    }
}
