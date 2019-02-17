using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Connexion : MonoBehaviour
{
    // ---------- ATRIBUES ----------

    public GameObject text_Position_1;      // Texte a la 1er position (En Bas a Gauche)
    public GameObject text_Position_2;      // Texte a la 2eme position (En Bas a Droite)
    public GameObject text_Position_3;      // Texte a la 3eme position (A Droite)
    public GameObject text_Position_4;      // Texte a la 4eme position (En Haut a Droite)
    public GameObject text_Position_5;      // Texte a la 5eme position (En Haut a Gauche)
    public GameObject text_Position_6;      // Texte a la 6eem position (A Gauche)

    // ---------- ATRIBUES ----------
    private int numJoueur;      // Pour affecter un numero de joueur (1 - 6)
    private Text affichageJoueur;   // Pour convertir de GameObjecte à Text
    private GameObject[] tabText = new GameObject[6];   //Tableau qui contient tout les GameObject "text_Position"
    private int nbJoueur ;  // Le nombre de joueur dans la partie (de 4 à 6)
    private int[] tabPosition = new int[6]; // Position des joueurs qui sont choisi

    // ---------- METHODES ----------

    // Methode d'inisialisation
    void Start()
    {
        // Recuperation du Nombre de joueur:
        //nbJoueur = PlayerPrefs.GetInt("monNbJoueur");
        nbJoueur = 4; // Nombre de Joueurs

        // Recuperation de la position des joueurs:
        tabPosition = new int[]  { 1, 3, 4, 5, 0, 0 }; // Position des joueurs



        //Initialisé le Tableau de GameObject "text_Position"
        tabText = new GameObject[] { text_Position_1, text_Position_2, text_Position_3, text_Position_4, text_Position_5, text_Position_6 };

        // Initialisé les textes à "Non Connecté".
        InitAffichageTextJoueur(tabPosition);
    }

    // Méthode de Mise A Jour
    void Update()
    {
        //EstConnecter();

    }


    // Méthode Affichage de connexion par joueurs
    void EstConnecter()
    {
        // Passage de GameObjecte a text
        //Text text_1 = text_Position_1.GetComponent<Text>();
        /*Text text_2 = text_Position_2.GetComponent<Text>();
        Text text_3 = text_Position_3.GetComponent<Text>();
        Text text_4 = text_Position_4.GetComponent<Text>();
        Text text_5 = text_Position_5.GetComponent<Text>();
        Text text_6 = text_Position_6.GetComponent<Text>();*/


        

        // Si jo
        //text_1.text = "Coucou" + "\n" +  "cc";


        affichageJoueur = tabText[0].GetComponent<Text>();
        affichageJoueur.text = " Joueur " + 1 + "\n" + " Pas Connecté ";


    }


    // Méthode Initialise l'Affichage du Text par Joueur
    void InitAffichageTextJoueur(int[] tPosition)
    {
        // Boucle FOR qui peut parcourir les 6 joueurs
        for (int i = 1; i <= 6; i++)
        {
            numJoueur = 1;  // Compteur pour affecter le bon numero de joueur

            // Boucle IF qui Affiche le Text seulement pour les joueurs
            if (EstDedans(i, tPosition)) //Si il fait partie du Tableau (Joueurs choisi)
            {
                affichageJoueur = tabText[i-1].GetComponent<Text>();
                affichageJoueur.color = Color.white; //Couleur de tout le texte 
                affichageJoueur.text = "Joueur " + numJoueur + "\n" + "<color=red> Pas Connecté </color>";
 
                
                numJoueur++;    //Incrementation du numero de Joueur
            }
            else
            {
                Destroy(tabText[i - 1]);    // Détruit les textes qui n'ont pas de joueurs
            }
        }
    }


    // Méthode qui revoie Vrai si un element (int) est dans un tableau d'entier
    private bool EstDedans(int element, int[] tab) 
    {
        bool trouver = false;

        for (int i = 0; i <= 5; i++)
        {
            if (element == tab[i]) 
            {
                trouver = true;
            }
        }

        return trouver;
    }

}

