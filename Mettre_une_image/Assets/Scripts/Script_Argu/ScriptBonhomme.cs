using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBonhomme : MonoBehaviour
{
    public bool niveau;

    void Start()
    {
        niveau = false;
    }

    void OnMouseDown()
    {
        if (niveau)
        {
            niveau = false;
        }
        else
        {
            niveau = true;
        }
    }

}
