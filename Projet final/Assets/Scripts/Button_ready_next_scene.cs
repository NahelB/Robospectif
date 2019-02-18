using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_ready_next_scene : MonoBehaviour
{
    public Button Button_ready;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    void OnMouseDown()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("scene_2");
    }
    
}
