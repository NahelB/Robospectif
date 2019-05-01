using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeton_usage : MonoBehaviour
{
    private bool estchanger = true;
    private SpriteRenderer rend;
    public Sprite Usage_positif, Usage_negatif;
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 curScreenPoint;
    private GameObject objet;
    private float startX, startY;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Usage_negatif = Resources.Load<Sprite>("Jetons/Usage_negatif");
        Usage_positif = Resources.Load<Sprite>("Jetons/Usage_positif");
        startX = curScreenPoint.x;
        startY = curScreenPoint.y;
        Debug.Log(startX);
        Debug.Log(startY);

    }



    // Update is called once per frame
    void Update()
    {
        // Position joueur 1
        if (curScreenPoint.x >= 425 && curScreenPoint.y <= 360
         && curScreenPoint.x >= 425 && curScreenPoint.y >= 30
         && curScreenPoint.x <= 675 && curScreenPoint.y <= 360
         && curScreenPoint.x <= 675 && curScreenPoint.y >= 30 )

        {
            curScreenPoint.x = startX;
            curScreenPoint.y = startY;
        }


        // Position joueur 2
        if (curScreenPoint.x >= 1125 && curScreenPoint.y <= 360
         && curScreenPoint.x >= 1125 && curScreenPoint.y >= 30
         && curScreenPoint.x <= 1375 && curScreenPoint.y <= 360
         && curScreenPoint.x <= 1375 && curScreenPoint.y >= 30)

        {
            Debug.Log("Joueur 2");
        }


        // Position joueur 3
        if (curScreenPoint.x >= 1550 && curScreenPoint.y <= 665
         && curScreenPoint.x >= 1550 && curScreenPoint.y >= 415
         && curScreenPoint.x <= 1900 && curScreenPoint.y <= 665
         && curScreenPoint.x <= 1900 && curScreenPoint.y >= 405)

        {
            Debug.Log("Joueur 3");
        }


        // Position joueur 4
        if (curScreenPoint.x >= 1150 && curScreenPoint.y <= 1050
         && curScreenPoint.x >= 1150 && curScreenPoint.y >= 710
         && curScreenPoint.x <= 1425 && curScreenPoint.y <= 1050
         && curScreenPoint.x <= 1425 && curScreenPoint.y >= 710)

        {
            Debug.Log("Joueur 4");
        }


        // Position joueur 5
        if (curScreenPoint.x >= 440 && curScreenPoint.y <= 1050
         && curScreenPoint.x >= 440 && curScreenPoint.y >= 705
         && curScreenPoint.x <= 705 && curScreenPoint.y <= 1050
         && curScreenPoint.x <= 705 && curScreenPoint.y >= 705)

        {
            Debug.Log("Joueur 5");
        }

        // Position joueur 6
        if (curScreenPoint.x >= 20 && curScreenPoint.y <= 670
         && curScreenPoint.x >= 20 && curScreenPoint.y >= 420
         && curScreenPoint.x <= 375 && curScreenPoint.y <= 670
         && curScreenPoint.x <= 375 && curScreenPoint.y >= 420)

        {
            Debug.Log("Joueur 6");
        }

    }



    private void OnMouseDown()
    {

        if (this.gameObject.name == "Usage_positif")
        {
            if (estchanger)
            {
                rend.sprite = Usage_negatif;
                estchanger = false;

            }
            else if (!estchanger)
            {
                rend.sprite = Usage_positif;
                estchanger = true;
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
