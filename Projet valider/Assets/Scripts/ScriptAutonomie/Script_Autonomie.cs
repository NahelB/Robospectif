using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_Autonomie : MonoBehaviour
{
    // ---------- ATTRIBUETS ----------
    public GameObject vollant;
    public Text Niveau_Bas;
    public Text Niveau_Haut;

    private bool autonomie; // ou  public int autonomie; (avec 0 ou 1)

    //Déplacement sourie
    public SpriteRenderer spriteRdr;
    private float positionSouris;
    private Vector3 positionVollant;

    //Pour la position du centre des Objets au debut
    public int positionDebutX = 0;  
    public int positionDebutY = 0;
    public int ecart = 3;

    // Taille par defaut du text:
    private int textPetit = 50;
    private int textGrand = 80;

    //Deplacement 
    private bool est_cliquer;
    private bool toucher = false;
    Vector3 mouseStartPos;
    Vector3 playerStartPos;


    // ---------- METHODES ----------

    // Methode d'inisialisation
    void Start()
    {
        spriteRdr = vollant.GetComponent<SpriteRenderer>();

        vollant.transform.position = new Vector3(positionDebutX, positionDebutY, 0);

        est_cliquer = false;


    }

    void OnMouseDown()
    {
        est_cliquer = true;
    }
    private void OnMouseUp()
    {
        est_cliquer = false;
    }

    // Méthode de mise a jour
    private void Update()
    {
        // Si le vollant a dépasser sa limite:
        if (toucher) { 
        if (vollant.transform.position.x > (positionDebutX + ecart))
        {
            vollant.transform.position = new Vector3((positionDebutX + ecart), positionDebutY, 0);
        }
        if (vollant.transform.position.x < (positionDebutX - ecart))
        {
            vollant.transform.position = new Vector3((positionDebutX - ecart), positionDebutY, 0);
        }
        }

        // Déplacement Vollant
        if (Input.GetMouseButtonDown(0) && est_cliquer)
        {
            toucher = true;
            mouseStartPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, positionDebutY, 0));
            playerStartPos = vollant.transform.position;
        }
        // else if (Input.GetMouseButtonUp(0) && est_cliquer)
        //{
        //   toucher = false;

        //  }

        if (toucher && est_cliquer)
        {
            positionSouris = Input.mousePosition.x;

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(positionSouris, positionDebutY, 0));
            Vector3 move = mousePos - mouseStartPos;
            positionVollant = playerStartPos + move;
            if (positionVollant.x <= (positionDebutX + ecart) && positionVollant.x >= (positionDebutX - ecart))
            {
                vollant.transform.position = positionVollant;
            }


        }

        //
        if (Input.GetMouseButtonUp(0) && toucher)
        {
            if (vollant.transform.position.x <= 0)
            {
                vollant.transform.position = new Vector3((positionDebutX - ecart), positionDebutY, 0);
                Niveau_Bas.fontSize = textGrand;
                Niveau_Haut.fontSize = textPetit;
            }
            else
            {
                vollant.transform.position = new Vector3((positionDebutX + ecart), positionDebutY, 0);
                Niveau_Haut.fontSize = textGrand;
                Niveau_Bas.fontSize = textPetit;
            }
        }
    }
}
