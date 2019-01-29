using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glissecarte : MonoBehaviour
{
    public GameObject player;
    public bool est_cliquer;
    // public ParticleSystem ps;


    bool dragging = false;
    Vector3 mouseStartPos;
    Vector3 playerStartPos;

    private void Start()
    {
        est_cliquer = false;
        // ps.GetComponent<Renderer>().sortingLayerName = "1erPlan";
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
        if (Input.GetMouseButtonDown(0) && est_cliquer)
        {
            dragging = true;
            mouseStartPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            playerStartPos = player.transform.position;
        }
        else if (Input.GetMouseButtonUp(0) && est_cliquer)
        {
            dragging = false;
        }

        if (dragging && est_cliquer)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
            Vector3 move = mousePos - mouseStartPos;
            player.transform.position = playerStartPos + move;
        }
    }
}
