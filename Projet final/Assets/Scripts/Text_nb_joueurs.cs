using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_nb_joueurs : MonoBehaviour
{
    public int nb_joueurs = 0;
    public GameObject text_nb_joueurs;

    // Start is called before the first frame update
    void Start()
    {
        MiseAJourText();
    }

    void MiseAJourText()
    {
        nb_joueurs = 0;

        if (Joueur_1_ready.joueur_1)
        {
            nb_joueurs += 1;
        }

        if (Joueur_2_ready.joueur_2)
        {
            nb_joueurs += 1;
        }

        if (Joueur_3_ready.joueur_3)
        {
            nb_joueurs += 1;
        }

        if (Joueur_4_ready.joueur_4)
        {
            nb_joueurs += 1;
        }

        if (Joueur_5_ready.joueur_5)
        {
            nb_joueurs += 1;
        }

        if (Joueur_6_ready.joueur_6)
        {
            nb_joueurs += 1;
        }

        Text nb_joueurs_text = text_nb_joueurs.GetComponent<Text>();
        nb_joueurs_text.text = "Il y a " + nb_joueurs + " joueurs enregistrés.";
    }


    void OnMouseDown()
    {
        MiseAJourText();
        Debug.Log("Clique sur le texte");
    }

    private void Update()
    {
        MiseAJourText();
    }
}
