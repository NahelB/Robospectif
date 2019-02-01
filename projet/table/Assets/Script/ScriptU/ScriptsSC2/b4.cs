using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class b4 : MonoBehaviour
{
    public Button button;
    private Text _yourButtonText;
    public static int estselec = 0 ;
    
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Image>().color =new Color(255, 0, 0);
        _yourButtonText = button.transform.Find("Text").GetComponent<Text>(); 
        _yourButtonText.text ="Player4";
        _yourButtonText.fontSize = 25;
        
        button.onClick.AddListener(ButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ButtonClicked()
    {
        if (estselec == 1)
        {
            button.GetComponent<Image>().color = new Color(255, 0, 0);
            estselec = 0;

        }
        else
        {
            button.GetComponent<Image>().color = new Color(0, 255, 0);
            estselec = 1;
        }
        
    }
    public static int getestselec()
    {
        return estselec;
    }
}
