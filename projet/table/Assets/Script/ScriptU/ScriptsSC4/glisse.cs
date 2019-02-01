using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class glisse : MonoBehaviour
{
    // Start is called before the first frame update
    private double horizontalSpeed = 2.0;
    public Image image;

    private Vector3 offset;

    void OnMouseDown()
    {

        offset = gameObject.transform.position -
                 Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    }

    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }

}
   
    
