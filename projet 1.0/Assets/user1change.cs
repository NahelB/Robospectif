using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class user1change : MonoBehaviour
{
    public Button buttonuser;

    // Start is called before the first frame update
    void Start()
    {
        buttonuser.onClick.AddListener(() =>SceneManager.LoadScene("2eme scene jeu"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
