using UnityEngine;
using UnityEngine.UI;

public class sc : MonoBehaviour
{
    public GameObject buttonJ1;
    public GameObject buttonJ2;
    public GameObject buttonJ3;
    public GameObject buttonJ4;
    public GameObject buttonJ5;
    public GameObject buttonJ6;
    public GameObject buttonplay;



    //public b1 b1;

    public static Vector2 _position1 = new Vector2(960+130,540+-410);
    public static Vector2 _position2 = new Vector2(960+-870,540+-410);
    public static Vector2 _position3 = new Vector2(960+-560,540+100);
    public static Vector2 _position4 = new Vector2(960+-870,540+410);
    public static Vector2 _position5 = new Vector2(960+130,540+410);
    public static Vector2 _position6= new Vector2(960+560,540+100);
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        buttonJ1.transform.position = new Vector2(960+450,540+-350);
        buttonJ2.transform.position = new Vector2(960+-450,540+-350);
        buttonJ3.transform.position = new Vector2(960+-750,540+0);
        buttonJ4.transform.position = new Vector2(960+-450,540+350);
        buttonJ5.transform.position = new Vector2(960+450,540+350);
        buttonJ6.transform.position = new Vector2(960+750,540+0);
        buttonplay.SetActive(false);
        text.text = "il y a " + Main.Global.Nbjoueur + " joueurs sélectionnés ";
        text.fontSize = 25;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Main.Global.Nbjoueur = b1.estselec + b2.estselec + b3.estselec + b4.estselec + b5.estselec + b6.estselec;
        
        text.text = "il y a " + Main.Global.Nbjoueur + " joueurs sélectionnés ";
        if (Main.Global.Nbjoueur >= 4)
        {
            buttonplay.SetActive(true);

        }
        else
        {
            buttonplay.SetActive(false);

        }

    }
   
}
