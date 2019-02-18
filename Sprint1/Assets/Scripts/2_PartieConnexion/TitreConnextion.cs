using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitreConnextion : MonoBehaviour
{
    // ---------- ATRIBUES ----------
    public GameObject titreScene;

    // ---------- METHODES ----------

    // Methode d'inisialisation
    void Start()
    {
        Text textTitre = titreScene.GetComponent<Text>();
        textTitre.color = Color.white; //Couleur de tout le texte 
        textTitre.text = "Connectez-vous a " +  "\n" + " la table ! ";
    }

    // Méthode de Mise A Jour
    void Update()
    {
        
    }

    // Méthode de clik sourie pour faire touner le Titre
    private void OnMouseUp()
    {
        transform.Rotate(Vector3.back, -90);
    }
}
