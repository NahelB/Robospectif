using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeton_societe : MonoBehaviour
{
    private bool estchanger = true;
    private SpriteRenderer rend;
    public Sprite Societe_positif, Societe_negatif;
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 curScreenPoint;
    private GameObject objet;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Societe_negatif = Resources.Load<Sprite>("Jetons/Societe_negatif");
        Societe_positif = Resources.Load<Sprite>("Jetons/Societe_positif");
    }



    // Update is called once per frame
    void Update()
    {
        if (curScreenPoint.x >= 800 && curScreenPoint.x <= 1800 && curScreenPoint.y >= 600)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            //  Debug.Log(" nop ");
        }
    }



    private void OnMouseDown()
    {

        if (this.gameObject.name == "Societe_positif")
        {
            if (estchanger)
            {
                rend.sprite = Societe_negatif;
                estchanger = false;
                Debug.Log("est changer = " + estchanger);
            }
            else if (!estchanger)
            {
                rend.sprite = Societe_positif;
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

    private void OnMouseDrag()
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
