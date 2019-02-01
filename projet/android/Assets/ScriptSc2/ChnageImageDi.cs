using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ChnageImageDi : MonoBehaviour, IPointerClickHandler
{
        public Image image;
        public Main.Image[] images;
        private Main.Image pics;
        public Text idText;
        private Main.Player p;
    
        // Start is called before the first frame update
        void Start()
    
        {
            Main.TabImage tab = Main.Global.TabD;
            int x;
            int y;
            x = Random.Range(1, tab.getTaille());
            y = Random.Range(1, tab.getTaille());
            while (x == y)
            {
                y = Random.Range(1, tab.getTaille());
            }
    
            images = new Main.Image[2];
            images[0] = tab.getImageind(x);
            images[1] = tab.getImageind(y);
    
            pics = images[0];
            
            p =  Main.Global.Player;
            ShowRandomImage(); 
        }
    
        void ShowRandomImage()
        {
            changetext((pics.getId().ToString()));
            p.Idcarte2 = pics.getId();
            image.sprite = pics.getSprite();
            image.enabled = true;   
        }
    
        public void OnPointerClick(PointerEventData eventData)
        {
            if (pics == images[1])
            {
                pics = images[0];
                
            }
            else
            {
                pics = images[1];
    
            }
            ShowRandomImage();
    
        }
        
        public void changetext(String str)
        {
            idText.text = ("l'id de la carte sélectionnée est : "+str);
        }
}
