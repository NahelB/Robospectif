using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnregistrerJoueurs : MonoBehaviour
{
    public SpriteRenderer rend;
    public bool joueur_1 = false;
    public Sprite Main_beige_1, Main_verte_1;
    public bool joueur_2 = false;
    public Sprite Main_beige_2, Main_verte_2;
    public int nb_joueurs = 0;
    public GameObject text_nb_joueurs;





    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Main_beige_1 = Resources.Load<Sprite>("Main_beige_1");
        Main_verte_1 = Resources.Load<Sprite>("Main_verte_1");
        //rend.sprite = Main_beige_1;


    }

    // Update is called once per frame
    void MiseAJourText()
    {
        Text nb_joueurs_text = text_nb_joueurs.GetComponent<Text>();
        nb_joueurs_text.text = "Il y a " + nb_joueurs + " joueurs enregistrés.";
    }

    void OnMouseDown()
    {

        if (this.gameObject.name == "Main_beige_1")
        {
            Debug.Log("clic sur " + this.gameObject.name);
            if (joueur_1 == false)
            {
                rend.sprite = Main_verte_1;
                joueur_1 = true;
                nb_joueurs = nb_joueurs + 1;
                MiseAJourText();
            }
            else if (joueur_1 == true)
            {
                rend.sprite = Main_beige_1;
                joueur_1 = false;
                nb_joueurs = nb_joueurs - 1;
                MiseAJourText();
            }
        }

        if (this.gameObject.name == "Main_beige_2")
        {
            Debug.Log("clic sur " + this.gameObject.name);
            if (joueur_2 == false)
            {
                rend.sprite = Main_verte_2;
                joueur_2 = true;
                nb_joueurs = nb_joueurs + 1;

                MiseAJourText();
            }
            else if (joueur_2 == true)
            {
                rend.sprite = Main_beige_2;
                joueur_2 = false;
                nb_joueurs = nb_joueurs - 1;

                MiseAJourText();
            }

            Debug.Log("Il y a " + nb_joueurs + " joueurs enregistrés.");
        }

    }

}