using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueurGagne : MonoBehaviour
{
    public GameObject couronne;
    public GameObject AutreCour1;
    public GameObject AutreCour2;


    void Start()
    {
        couronne.SetActive(false);
        AutreCour1.SetActive(false);
        AutreCour2.SetActive(false);


    }

    void OnMouseDown()
    {
        couronne.SetActive(true);
        Destroy(AutreCour1);
        Destroy(AutreCour2);


    }
}
