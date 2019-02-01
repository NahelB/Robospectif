﻿using System.Resources;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class user2image : MonoBehaviour , IPointerClickHandler
{
    private Sprite pics;
    public Image image;

    private Main.TabImage sprite;

    private Sprite[] tab;
    // Start is called before the first frame update
    void Start()
    {         
         sprite = Main.Global.TabL;
         tab = new Sprite[2];
         int x;
         int y;
         x = Random.Range(1,sprite.getTaille());
         y = Random.Range(1,sprite.getTaille());
         while (x == y)
         {
             y = Random.Range(1,sprite.getTaille());
             
         }

         tab[0] = sprite.getImageind(x).getSprite();
         tab[1] = sprite.getImageind(y).getSprite();

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
