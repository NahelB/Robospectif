using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValiderVainqueur : MonoBehaviour
{
    public int  vainqueur;
    // Start is called before the first frame update
    void Start()
    {
        vainqueur = 0 ;
    }

    // Update is called once per frame
    void Update()
    {
        if (P1_couronne.couronne_active == 1)
        {
            vainqueur = 1 ;
        }
        if (P2_couronne.couronne_active == 1)
        {
            vainqueur = 2 ;
        }
        if (P3_couronne.couronne_active == 1)
        {
            vainqueur = 3 ;
        }
        if (P4_couronne.couronne_active == 1)
        {
            vainqueur = 4;
        }
        if (P5_couronne.couronne_active == 1)
        {
            vainqueur = 5;
        }
        if (P6_couronne.couronne_active == 1)
        {
            vainqueur = 6;
        }


        if (Input.GetMouseButtonDown(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene_fin_tour");
        }
    }


}
