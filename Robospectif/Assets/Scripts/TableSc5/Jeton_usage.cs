﻿using System.Collections;
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
    public static int[] nb_bonus;
    public static int[] nb_malus;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Usage_negatif = Resources.Load<Sprite>("Jetons/Usage_negatif");
        Usage_positif = Resources.Load<Sprite>("Jetons/Usage_positif");
        nb_bonus = new int[6];
        nb_malus = new int[6];

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
            if (estchanger)
            {
                
                nb_bonus[0]++;
                Debug.Log(nb_bonus[0]);
            }
            else
                nb_malus[0]++;
            this.gameObject.SetActive(false);

        }


        // Position joueur 2
        if (curScreenPoint.x >= 1125 && curScreenPoint.y <= 360
         && curScreenPoint.x >= 1125 && curScreenPoint.y >= 30
         && curScreenPoint.x <= 1375 && curScreenPoint.y <= 360
         && curScreenPoint.x <= 1375 && curScreenPoint.y >= 30)

        {
            if (estchanger)
            {
                nb_bonus[1]++;
                Debug.Log(nb_bonus[1]);
            }
            else
                nb_malus[1]++;
            this.gameObject.SetActive(false);
        }


        // Position joueur 3
        if (curScreenPoint.x >= 1550 && curScreenPoint.y <= 665
         && curScreenPoint.x >= 1550 && curScreenPoint.y >= 415
         && curScreenPoint.x <= 1900 && curScreenPoint.y <= 665
         && curScreenPoint.x <= 1900 && curScreenPoint.y >= 405)

        {
            if (estchanger)
            {
                nb_bonus[2]++;
                Debug.Log(nb_bonus[2]);
            }
            else
                nb_malus[2]++;
            this.gameObject.SetActive(false);
        }


        // Position joueur 4
        if (curScreenPoint.x >= 1150 && curScreenPoint.y <= 1050
         && curScreenPoint.x >= 1150 && curScreenPoint.y >= 710
         && curScreenPoint.x <= 1425 && curScreenPoint.y <= 1050
         && curScreenPoint.x <= 1425 && curScreenPoint.y >= 710)

        {
            if (estchanger)
            {
                nb_bonus[3]++;
                Debug.Log(nb_bonus[3]);
            }
            else
                nb_malus[3]++;
            this.gameObject.SetActive(false);
        }


        // Position joueur 5
        if (curScreenPoint.x >= 440 && curScreenPoint.y <= 1050
         && curScreenPoint.x >= 440 && curScreenPoint.y >= 705
         && curScreenPoint.x <= 705 && curScreenPoint.y <= 1050
         && curScreenPoint.x <= 705 && curScreenPoint.y >= 705)

        {
            if (estchanger)
            {
                nb_bonus[4]++;
                Debug.Log(nb_bonus[4]);
            }
            else
                nb_malus[4]++;
            this.gameObject.SetActive(false);
        }

        // Position joueur 6
        if (curScreenPoint.x >= 20 && curScreenPoint.y <= 670
         && curScreenPoint.x >= 20 && curScreenPoint.y >= 420
         && curScreenPoint.x <= 375 && curScreenPoint.y <= 670
         && curScreenPoint.x <= 375 && curScreenPoint.y >= 420)

        {
            if (estchanger)
            {
                nb_bonus[5]++;
                Debug.Log(nb_bonus[5]);
            }
            else
                nb_malus[5]++;
            this.gameObject.SetActive(false);
        }

    }


    private void OnMouseDown()
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
