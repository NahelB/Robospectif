using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptArguments : MonoBehaviour
{
    public GameObject argument;

    //Changement couleurs
    public SpriteRenderer spriteRdr;
    public Sprite spritePositif;
    public Sprite spriteNegatif;
    public GameObject bonhomme;

    bool verification;

    //Deplacement jetons
    public bool est_cliquer;
    bool dragging = false;
    Vector3 mouseStartPos;
    Vector3 playerStartPos;


    // Start is called before the first frame update
    void Start()
    {
        spriteRdr = argument.GetComponent<SpriteRenderer>();
        spriteRdr.sprite = spritePositif;
        verification = bonhomme.GetComponent<ScriptBonhomme>().niveau;

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


    private void Update()
    {

        // Changer couleur (Lien avec scripte Bonhomme)
        if (spriteRdr.sprite == spritePositif && bonhomme.GetComponent<ScriptBonhomme>().niveau)
        {
            spriteRdr.sprite = spriteNegatif;
        }
        else if (spriteRdr.sprite == spriteNegatif && !bonhomme.GetComponent<ScriptBonhomme>().niveau)
        {
            spriteRdr.sprite = spritePositif;
        }



        // Déplacement Jetons Arguments
        if (Input.GetMouseButtonDown(0) && est_cliquer)
        {
            dragging = true;
            mouseStartPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            playerStartPos = argument.transform.position;
        }
        else if (Input.GetMouseButtonUp(0) && est_cliquer)
        {
            dragging = false;
        }

        if (dragging && est_cliquer)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            Vector3 move = mousePos - mouseStartPos;
            argument.transform.position = playerStartPos + move;
        }


    }
}
