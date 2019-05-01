using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AffichageCouronne : MonoBehaviour
{
    public int JoueurCourant;
    //public static Partie partieCourante;

    public GameObject personnage1;
    public GameObject environnement_1;
    public GameObject couronne_1;
    public GameObject personnage2;
    public GameObject environnement_2;
    public GameObject couronne_2;
    public GameObject personnage3;
    public GameObject environnement_3;
    public GameObject couronne_3;
    public GameObject personnage4;
    public GameObject environnement_4;
    public GameObject couronne_4;
    public GameObject personnage5;
    public GameObject environnement_5;
    public GameObject couronne_5;
    public GameObject personnage6;
    public GameObject environnement_6;
    public GameObject couronne_6;

    public Sprite[] images = InitDebat.envoi;



    // Start is called before the first frame update
    void Start()
    {
        images = new Sprite[6];

        JoueurCourant = SansHUD.premierFini;


        switch (JoueurCourant)
        {

            case 1:

                Destroy(personnage1);
                Destroy(environnement_1);
                Destroy(couronne_1);
                break;

            case 2:

                Destroy(personnage2);
                Destroy(environnement_2);
                Destroy(couronne_2);

                break;


            case 3:
                Destroy(personnage3);
                Destroy(environnement_3);
                Destroy(couronne_3);
                break;


            case 4:
                Destroy(personnage4);
                Destroy(environnement_4);
                Destroy(couronne_4);

                break;

            case 5:
                Destroy(personnage5);
                Destroy(environnement_5);
                Destroy(couronne_5);

                break;

            case 6:
                Destroy(personnage6);
                Destroy(environnement_6);
                Destroy(couronne_6);

                break;

        }

        if (images[0] != null) personnage1.GetComponent<SpriteRenderer>().sprite = images[0];
        if (images[1] != null) personnage2.GetComponent<SpriteRenderer>().sprite = images[1];
        if (images[2] != null) personnage3.GetComponent<SpriteRenderer>().sprite = images[2];
        if (images[3] != null) personnage4.GetComponent<SpriteRenderer>().sprite = images[3];
        if (images[4] != null) personnage5.GetComponent<SpriteRenderer>().sprite = images[4];
        if (images[5] != null) personnage6.GetComponent<SpriteRenderer>().sprite = images[5];


        /*for (int i = 0; i < partieCourante.Joueurs.Length(); i++)
        {
            if (partieCourante.Joueurs[i] == 0)
            {
                switch (i+1)
                {

                    case 1:

                        Destroy(personnage1);
                        Destroy(environnement_1);
                        Destroy(couronne_1);
                        break;

                    case 2:

                        Destroy(personnage2);
                        Destroy(environnement_2);
                        Destroy(couronne_2);

                        break;


                    case 3:
                        Destroy(personnage3);
                        Destroy(environnement_3);
                        Destroy(couronne_3);
                        break;


                    case 4:
                        Destroy(personnage4);
                        Destroy(environnement_4);
                        Destroy(couronne_4);

                        break;

                    case 5:
                        Destroy(personnage5);
                        Destroy(environnement_5);
                        Destroy(couronne_5);

                        break;

                    case 6:
                        Destroy(personnage6);
                        Destroy(environnement_6);
                        Destroy(couronne_6);

                        break;
                }
            }
        }*/

    }

    private void Update()
    {

        
    }
}
