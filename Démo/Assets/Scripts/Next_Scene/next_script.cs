using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//test
using UnityEngine.SceneManagement;

public class next_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene1"))
        {
            SceneManager.LoadScene("scene2");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene2"))
        
        {
            SceneManager.LoadScene("scene3");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene3"))
        {
            SceneManager.LoadScene("scene4");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene4"))
        {
            SceneManager.LoadScene("scene5");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene5"))
        {
            SceneManager.LoadScene("scene6");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene6"))
        {
            SceneManager.LoadScene("scene7");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene7"))
        {
            SceneManager.LoadScene("scene1");
        }



        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("sceneTest"))
        {
            SceneManager.LoadScene("scene1");
        }
    }



}
