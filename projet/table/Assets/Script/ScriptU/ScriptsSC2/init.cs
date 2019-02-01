using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(inits());
    }

    // Update is called once per frame

    IEnumerator inits()
    {
        WWWForm form = new WWWForm();
        WWW www = new WWW("https://primsie-spears.000webhostapp.com/init.php",form);
        yield return www;
    }
}
