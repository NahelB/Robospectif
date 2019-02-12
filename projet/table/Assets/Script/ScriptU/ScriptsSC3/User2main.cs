using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class User2main : MonoBehaviour
{
    public Image imagep11;
    public Image imagep12;
    public Image imagep13;
    public Image imagep14;
    public Image imagep15;

    public Image imagep21;
    public Image imagep22;
    public Image imagep23;
    public Image imagep24;
    public Image imagep25;

    public Image imagep31;
    public Image imagep32;
    public Image imagep33;
    public Image imagep34;
    public Image imagep35;
    
    public Image imagep41;
    public Image imagep42;
    public Image imagep43;
    public Image imagep44;
    public Image imagep45;
    
    public Image imagep51;
    public Image imagep52;
    public Image imagep53;
    public Image imagep54;
    public Image imagep55;
    
    public Image imagep61;
    public Image imagep62;
    public Image imagep63;
    public Image imagep64;
    public Image imagep65;

    public Text textp1;
    public Text textp2;
    public Text textp3;
    public Text textp4;
    public Text textp5;
    public Text textp6;
    
    public int[] tabPlace;
    

    public Image[] imagetab;
    public Image[] imagetab1;
    private Text[] texTab;
    public Vector2[] vector2;
    private bool alljoueurselect = false;

    void Start()
    {    
        imagetab = new Image[31];
        texTab = new Text[7]{null,textp1,textp2,textp3,textp4,textp5,textp6};
        int x = 1;
        tabPlace = new int[7]{0,1,1,1,1,1,1};
        if (b1.estselec != 1)
        {       
            Destroy(imagep11);
            Destroy(imagep12);
            Destroy(imagep13);
            Destroy(imagep14);
            Destroy(imagep15);
            tabPlace[1] = 0;
            Destroy(textp1);
        }
        else
        {
                imagetab[x++] = imagep11;
                imagetab[x++] = imagep12;
                imagetab[x++] = imagep13;
                imagetab[x++] = imagep14;
                imagetab[x++] = imagep15;
        }




        if (b2.estselec != 1)
        {
            Destroy(imagep21);
            Destroy(imagep22);
            Destroy(imagep23);
            Destroy(imagep24);
            Destroy(imagep25);
            tabPlace[2] = 0;
            Destroy(textp2);
        }else
        {
            imagetab[x++] = imagep21;
            imagetab[x++] = imagep22;
            imagetab[x++] = imagep23;
            imagetab[x++] = imagep24;
            imagetab[x++] = imagep25;
        } 
           

        if (b3.estselec != 1)
        {
            Destroy(imagep31);
            Destroy(imagep32);
            Destroy(imagep33);
            Destroy(imagep34);
            Destroy(imagep35);
            tabPlace[3] = 0;
            Destroy(textp3);
        }else
        {
            imagetab[x++] = imagep31;
            imagetab[x++] = imagep32;
            imagetab[x++] = imagep33;
            imagetab[x++] = imagep34;
            imagetab[x++] = imagep35;
        } 

        if (b4.estselec != 1)
        {
            Destroy(imagep41);
            Destroy(imagep42);
            Destroy(imagep43);
            Destroy(imagep44);
            Destroy(imagep45);
            tabPlace[4] = 0;
            Destroy(textp4);
        }else
        {
            imagetab[x++] = imagep41;
            imagetab[x++] = imagep42;
            imagetab[x++] = imagep43;
            imagetab[x++] = imagep44;
            imagetab[x++] = imagep45;
        } 
        
        if (b5.estselec != 1)
        {
            Destroy(imagep51);
            Destroy(imagep52);
            Destroy(imagep53);
            Destroy(imagep54);
            Destroy(imagep55);
            tabPlace[5] = 0;
            Destroy(textp5);
        } else
        {
            imagetab[x++] = imagep51;
            imagetab[x++] = imagep52;
            imagetab[x++] = imagep53;
            imagetab[x++] = imagep54;
            imagetab[x++] = imagep55;
        }

        if (b6.estselec != 1)
        {            
            Destroy(imagep61);
            Destroy(imagep62);
            Destroy(imagep63);
            Destroy(imagep64);
            Destroy(imagep65);
            tabPlace[6] = 0;
            Destroy(textp6);
        }else
        
        {
            imagetab[x++] = imagep61;
            imagetab[x++] = imagep62;
            imagetab[x++] = imagep63;
            imagetab[x++] = imagep64;
            imagetab[x++] = imagep65;
        }

        int j = 1;
        for (int i = 1; i < 7; i++)
        {
            if (tabPlace[i] == 1)
            {
                Main.Global.tabPlayer[j].Place = i;
                j++;
            }
        }

        for (int i = 1; i < x; i++)
        {
            imagetab[i].enabled = false;
        }
        //Debug.Log(Main.Global.ToString());
        if (alljoueurselect)
        {
            StartCoroutine(changePlace());
            InvokeRepeating("requette", 0f, 1f);
        }
        else
        {
            InvokeRepeating("checkallselect", 0f, 1f);
        }
       

        
        
    }
    void FixedUpdate()
    {

    }

    
    IEnumerator changePlace()
    {
        WWWForm form = new WWWForm();
        form.AddField("user1",Main.Global.tabPlayer[1].Place);
        form.AddField("user2",Main.Global.tabPlayer[2].Place);
        form.AddField("user3",Main.Global.tabPlayer[3].Place);
        form.AddField("user4",Main.Global.tabPlayer[4].Place);
        form.AddField("user5",Main.Global.tabPlayer[5].Place);
        form.AddField("user6",Main.Global.tabPlayer[6].Place);

        WWW www = new WWW("https://primsie-spears.000webhostapp.com/changePlaceCarte.php",form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("ok");
        }
        else
        {
            Debug.Log("erroer"+www.text);
        }
    }
    
    IEnumerator checkestok()
    {
        WWWForm logform = new WWWForm();
        var www = new WWW("https://primsie-spears.000webhostapp.com/select.php", logform);
        yield return www;

        string[] data = www.text.Split(new string[] {","}, System.StringSplitOptions.None);
        int x = 0;
        
        for (int i = 1; i < 7; i++)
        {
            Main.Global.tabPlayer[i] = new Main.Player(int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]),
                int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]));
        }
    }

    
    private void requette()
    {
        
        StartCoroutine(checkestok());
        if (Main.Global.tabPlayer[1].IsOk == 1)
        {
            texTab[Main.Global.tabPlayer[1].Place].enabled = false;
            imagetab[1].sprite = Main.Global.TabL.getImageind(Main.Global.tabPlayer[1].Idcarte1).Sprite;
            imagetab[2].sprite = Main.Global.TabD.getImageind(Main.Global.tabPlayer[1].Idcarte2).Sprite;
            imagetab[3].sprite = Main.Global.TabE.getImageind(Main.Global.tabPlayer[1].Idcarte3).Sprite;
        }
        if (Main.Global.tabPlayer[2].IsOk == 1)
        {
            texTab[Main.Global.tabPlayer[2].Place].enabled = false;
            imagetab[6].sprite = Main.Global.TabL.getImageind(Main.Global.tabPlayer[2].Idcarte1).Sprite;
            imagetab[7].sprite = Main.Global.TabD.getImageind(Main.Global.tabPlayer[2].Idcarte2).Sprite;
            imagetab[8].sprite = Main.Global.TabE.getImageind(Main.Global.tabPlayer[2].Idcarte3).Sprite;
        }
        if (Main.Global.tabPlayer[3].IsOk == 1)
        {
            texTab[Main.Global.tabPlayer[3].Place].enabled = false;
            imagetab[11].sprite = Main.Global.TabL.getImageind(Main.Global.tabPlayer[3].Idcarte1).Sprite;
            imagetab[12].sprite = Main.Global.TabD.getImageind(Main.Global.tabPlayer[3].Idcarte2).Sprite;
            imagetab[13].sprite = Main.Global.TabE.getImageind(Main.Global.tabPlayer[3].Idcarte3).Sprite;
        }
        if (Main.Global.tabPlayer[4].IsOk == 1)
        {
            texTab[Main.Global.tabPlayer[4].Place].enabled = false;
            imagetab[16].sprite = Main.Global.TabL.getImageind(Main.Global.tabPlayer[4].Idcarte1).Sprite;
            imagetab[17].sprite = Main.Global.TabD.getImageind(Main.Global.tabPlayer[4].Idcarte2).Sprite;
            imagetab[18].sprite = Main.Global.TabE.getImageind(Main.Global.tabPlayer[4].Idcarte3).Sprite;
        }
        if (Main.Global.tabPlayer[5].IsOk == 1)
        {
            texTab[Main.Global.tabPlayer[5].Place].enabled = false;
            imagetab[21].sprite = Main.Global.TabL.getImageind(Main.Global.tabPlayer[5].Idcarte1).Sprite;
            imagetab[22].sprite = Main.Global.TabD.getImageind(Main.Global.tabPlayer[5].Idcarte2).Sprite;
            imagetab[23].sprite = Main.Global.TabE.getImageind(Main.Global.tabPlayer[5].Idcarte3).Sprite;
        }
        if (Main.Global.tabPlayer[6].IsOk == 1)
        {
            texTab[Main.Global.tabPlayer[6].Place].enabled = false;
            imagetab[26].sprite = Main.Global.TabL.getImageind(Main.Global.tabPlayer[5].Idcarte1).Sprite;
            imagetab[27].sprite = Main.Global.TabD.getImageind(Main.Global.tabPlayer[5].Idcarte2).Sprite;
            imagetab[28].sprite = Main.Global.TabE.getImageind(Main.Global.tabPlayer[5].Idcarte3).Sprite;
            
        }

      
        int x = 6;                                                                                                    
        for (int i = 1; i < x; i++)
        {
            imagetab[i].enabled = Main.Global.tabPlayer[1].IsOk != 0;
        }
        
       x = 11 ;

        for (int i = 6; i < x; i++)
        {
            imagetab[i].enabled = Main.Global.tabPlayer[2].IsOk != 0; 
            
        }
        x = 16;

        for (int i = 11; i < x; i++)
        {
            imagetab[i].enabled = Main.Global.tabPlayer[3].IsOk != 0; 
        }
        x = 21;

        for (int i = 16; i < x; i++)
        {
            imagetab[i].enabled = Main.Global.tabPlayer[4].IsOk != 0; 
        }
        x = 26;
        if (Main.Global.Nbjoueur > 4)
        {
            for (int i = 21; i < x; i++)
            {
                imagetab[i].enabled = Main.Global.tabPlayer[5].IsOk != 0; 
            }
            x =31;
            if (Main.Global.Nbjoueur > 5)
            {
                for (int i = 26; i < x; i++)
                {
                    imagetab[i].enabled = Main.Global.tabPlayer[6].IsOk != 0;
                }
            }
        }
        
    }

    private void checkallselect()
    {
        Boolean test = false;
        int count = 0;
        for (int i = 0; i < Main.Global.Nbjoueur; i++)
        {
            count = count + Main.Global.tabPlayer[i].IsSelect;
        }

        if (count == Main.Global.Nbjoueur)
        {
            alljoueurselect = true;
        }
        else
        {
            count = 0;
        }
    }
}