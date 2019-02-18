using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuchange : MonoBehaviour
{
    public Button buttonuser;
    public Button buttonadmin;
    public Button buttonanalyst;
    // Start is called before the first frame update
    void Start()
    {
        buttonuser.onClick.AddListener(user);
        buttonadmin.onClick.AddListener(admin);
        buttonanalyst.onClick.AddListener(analyst);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void user()
    {
        SceneManager.LoadScene("user");
    }
    void admin()
    {
        SceneManager.LoadScene("admin");
    }
    void analyst()
    {
        SceneManager.LoadScene("analyst");
    }
}
