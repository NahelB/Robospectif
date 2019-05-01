using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public bool estchanger = true;
    public SpriteRenderer rend;
    public Sprite Planete_positif, Planete_negatif;
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 curScreenPoint;
    private GameObject objet;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Planete_negatif = Resources.Load<Sprite>("Jetons/Planete_negatif");
        Planete_positif = Resources.Load<Sprite>("Jetons/Planete_positif");

        
        
    }



    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log(" x = " + curScreenPoint.x);
        Debug.Log(" y = " + curScreenPoint.y);
        */
        
    }



    void OnMouseDown()
    {

        if (this.gameObject.name == "Planete_positif")
        {
            if (estchanger)
            {
                rend.sprite = Planete_negatif;
                estchanger = false;
                Debug.Log("est changer = " + estchanger);
            }
            else if (!estchanger)
            {
                rend.sprite = Planete_positif;
                estchanger = true;
                Debug.Log("est changer = " + estchanger);
            }

        }

        Vector3 position = Vector3.zero;
        if (Input.touchCount > 0)
        {
            position = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, 0);
        }
        else
        {
            position = Input.mousePosition;
        }
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        offset = transform.position - Camera.main.ScreenToWorldPoint(
            new Vector3(position.x, position.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        // calcul la nouvelle position
        Vector3 position = Vector3.zero;
        if (Input.touchCount > 0)
        {
            position = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, 0);
        }
        else
        {
            position = Input.mousePosition;
        }
        curScreenPoint = new Vector3(position.x, position.y, screenPoint.z);
        transform.position = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        // Debug.Log("pos is " + curScreenPoint.x);


        

    }



}
