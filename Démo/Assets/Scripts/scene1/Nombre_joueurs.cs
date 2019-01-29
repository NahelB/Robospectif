using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nombre_joueurs : MonoBehaviour
{
    public GameObject text_nb_joueurs;
    public int nb_joueurs = 13;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void MiseAJourText()
    {
        Text nb_joueurs_text = text_nb_joueurs.GetComponent<Text>();
        nb_joueurs_text.text = "Il y a " + nb_joueurs + " joueurs enregistrés.";
    }



}
