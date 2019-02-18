using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    public Button button;
    public string LevelToLoad;


    // Start is called before the first frame update
    void Start()
    {
                button.onClick.AddListener(ButtonClicked);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ButtonClicked()
    {
        if (sc.getnbjoueur() > 4)
        {
            LoadLevel();
        }
    }
    
    
    void LoadLevel()
    {          
        SceneManager.LoadScene("Untitled");
    }
}
