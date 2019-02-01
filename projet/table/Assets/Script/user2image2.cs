using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class user2image2 : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    private Sprite pics;
    public Image image;

    private Main.TabImage sprite;

    private Sprite[] tab;
    // Start is called before the first frame update
    void Start()
    {         
        sprite = Main.Global.TabD;
        tab = new Sprite[2];
        int x;
        int y;
        x = Random.Range(1,sprite.getTaille());
        y = Random.Range(1,sprite.getTaille());
        while (x == y)
        {
            y = Random.Range(1,sprite.getTaille());
             
        }

        tab[0] = sprite.getImageind(x).Sprite;
        tab[1] = sprite.getImageind(y).Sprite;

        pics = tab[0];
        ShowRandomImage();
      
    }

    void ShowRandomImage()
    {
        
        image.sprite = pics;
        image.enabled = true;   
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (pics == tab[1])
        {
            pics = tab[0];

        }
        else
        {
            pics = tab[1];

        }
        ShowRandomImage();

    }
}
