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
    public int[] tabNum ;   //Tableau qui contient tout la position et le numero de joueurs 
    private int tousConnecter;

        // Recuperation scene d'avant
    private int nbJoueur ;  // Le nombre de joueur dans la partie (de 4 à 6)
    private int[] tabPosition = new int[6]; // Position des joueurs qui sont choisi

    // ---------- METHODES ----------

    // Methode d'inisialisation
    void Start()
    {
        // Recuperation du Nombre de joueur:
        //nbJoueur = PlayerPrefs.GetInt("monNbJoueur");     // Nombre de Joueurs
        nbJoueur = 6; // Nombre de Joueurs

        // Recuperation de la position des joueurs:
        /*for (int i = 0; i <= 5; i++)
        {
            tabPosition[i] = PlayerPrefs.GetInt("maPosition" + (i+1) );     // Position des joueurs
        }*/
        tabPosition = new int[]  { 1, 2, 3, 4, 5, 6 }; // Position des joueurs



        //Initialisé le Tableau de GameObject "text_Position"
        tabText = new GameObject[] { text_Position_1, text_Position_2, text_Position_3, text_Position_4, text_Position_5, text_Position_6 };

        //Initialisé le Tableau qui contient tout la position et le numero de joueurs 
        tabNum = new int[2* nbJoueur];

        // Initialisé les textes à "Non Connecté".
        InitAffichageTextJoueur(tabPosition);

    }

    // Méthode de Mise A Jour
    void Update()
    {

        AfficheJoueurConnecter();

    }


    // Méthode Initialise l'Affichage du Text par Joueur
    void InitAffichageTextJoueur(int[] tPosition)
    {
        numJoueur = 1;  // Compteur pour affecter le bon numero de joueur

        // Boucle FOR qui peut parcourir les 6 joueurs
        for (int i = 1; i <= 6; i++)
        {
            

            // Boucle IF qui Affiche le Text seulement pour les joueurs
            if (EstDedans(i, tPosition)) //Si il fait partie du Tableau (Joueurs choisi)
            {
                //Ecrie dans la partie Text
                affichageJoueur = tabText[i-1].GetComponent<Text>();
                affichageJoueur.color = Color.white; //Couleur de tout le texte 
                affichageJoueur.text = "Joueur " + numJoueur + "\n" + "<color=red> Pas Connecté </color>";

                // Remplie le Tableau "tabNum" avec la position et le numero de joueurs 
                tabNum[(numJoueur-1)*2] = i; // Position
                tabNum[((numJoueur - 1) * 2) +1] = numJoueur; // Numero

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


    // -------------------------------------------------------------------------------------

    // Méthode Affichage de connexion par joueurs
    void AfficheJoueurConnecter()
    {
        tousConnecter = 0; //Initialise la variable a 0


        // Boucle FOR qui peut parcourir le tableau  "tabNum" (position/numero de joueurs) 
        for (int i = 0; i <= (2 * nbJoueur)-1; i = i + 2)
        {

            // Boucle IF qui verifie si le Joueurs est connecté
            if (estConnecte(tabNum[i]))
            {
                //Modifie le text
                affichageJoueur = tabText[tabNum[i] - 1].GetComponent<Text>();
                affichageJoueur.color = Color.white; //Couleur de tout le texte 
                affichageJoueur.text = "Joueur " + tabNum[i + 1] + "\n" + "<color=blue> Connecté </color>";

                tousConnecter++;
            }

        }

        if (tousConnecter == nbJoueur)
        {
            // Changer Titre
            // Mettre du temps
            //Changer de scene
        }
    }


    // Méthode qui revoie Vrai si un joueur (int) est Connecté
    private bool estConnecte(int joueur)
    {
        bool Connecter = false; //variable qui est Vrai si le joueur est connecté

        //Recuperer les infos sur la connection du joueurs


        //Verifie si le joueur c'est conecté
        if (joueur == 1 || joueur == 4 )
        {
            Connecter = true;
        }

        return Connecter;
    }

}

