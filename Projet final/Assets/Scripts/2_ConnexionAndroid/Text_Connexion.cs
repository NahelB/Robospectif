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


    // ---------- METHODES ----------

    // Methode d'inisialisation
    void Start()
    {
        // Info a avoir:
        // Nombre de Joueurs
        // Position des joueurs
        // Initialisé les textes à "Non Connecté".
        EstConnecter();
    }

    // Méthode de Mise A Jour
    void Update()
    {
        Text text_1 = text_Position_1.GetComponent<Text>();
    }


    // Méthode Affichage de connexion part joueurs
    void EstConnecter()
    {
        // Passage de GameObjecte a text
        Text text_1 = text_Position_1.GetComponent<Text>();
        /*Text text_2 = text_Position_2.GetComponent<Text>();
        Text text_3 = text_Position_3.GetComponent<Text>();
        Text text_4 = text_Position_4.GetComponent<Text>();
        Text text_5 = text_Position_5.GetComponent<Text>();
        Text text_6 = text_Position_6.GetComponent<Text>();*/

        // Si jo
        text_1.text = "Coucou.";
    }
}
