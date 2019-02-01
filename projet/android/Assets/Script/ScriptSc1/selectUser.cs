using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selectUser : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public int i;
    public Scene scene;
    private Main.Global g;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        InvokeRepeating("requette", 3f, 1f);

    }    
    
    void ButtonClicked(int i)
    {
        //Output this to console when the Button3 is clicked
        Main.Global.Player=SelectNmbPlayer.getPlayer(i);
        
        Debug.Log(Main.Global.Player.ToString());
        StartCoroutine(selectPlayer(i));
        SceneManager.LoadScene(scene.handle);
    }

    IEnumerator selectPlayer(int i)
    {
        WWWForm form = new WWWForm();
        form.AddField("id",i);
        WWW www = new WWW("https://primsie-spears.000webhostapp.com/estSelect.php",form);
        yield return www;
    }
    
    private void requette()
    {
        button.onClick.AddListener(() => ButtonClicked(i));
    }
}

