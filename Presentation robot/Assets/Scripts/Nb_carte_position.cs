﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nb_carte_position : MonoBehaviour
{
    public static int nb_carte_position_1;
    public static int nb_carte_position_2;
    public static int nb_carte_position_3;

    // Start is called before the first frame update
    void Start()
    {
        nb_carte_position_1 = 0;
        nb_carte_position_2 = 0;
        nb_carte_position_3 = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        nb_carte_position_1 = 0;

        if (Placement_equipement_1.carte_1_position_1)
        {
            nb_carte_position_1 = nb_carte_position_1 + 1;
        }

        if (Placement_equipement_2.carte_2_position_1)
        {
            nb_carte_position_1 = nb_carte_position_1 + 1;
        }

        if (Placement_equipement_3.carte_3_position_1)
        {
            nb_carte_position_1 = nb_carte_position_1 + 1;
        }


        nb_carte_position_2 = 0;

        if (Placement_equipement_1.carte_1_position_2)
        {
            nb_carte_position_2 = nb_carte_position_2 + 1;
        }

        if (Placement_equipement_2.carte_2_position_2)
        {
            nb_carte_position_2 = nb_carte_position_2 + 1;
        }

        if (Placement_equipement_3.carte_3_position_2)
        {
            nb_carte_position_2 = nb_carte_position_2 + 1;
        }


        nb_carte_position_3 = 0;

        if (Placement_equipement_1.carte_1_position_3)
        {
            nb_carte_position_3 = nb_carte_position_3 + 1;
        }

        if (Placement_equipement_2.carte_2_position_3)
        {
            nb_carte_position_3 = nb_carte_position_3 + 1;
        }

        if (Placement_equipement_3.carte_3_position_3)
        {
            nb_carte_position_3 = nb_carte_position_3 + 1;
        }
        
        
       // Debug.Log(nb_carte_position_1);
    }
}
