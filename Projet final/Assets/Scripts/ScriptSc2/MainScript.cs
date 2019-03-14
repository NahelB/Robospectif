using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using UnityEngine.Networking;

public class MainScript : MonoBehaviour
{
    public static Main.Player player;
    public Text text;
    public Image dimensionGO1;
    public Image dimensionGO2;
    public Image dimensionGO3;
    public Image locomotionGO1;
    public Image locomotionGO2;
    public Image locomotionGO3;
    public Image equipementGO1;
    public Image equipementGO2;
    public Image equipementGO3;
    public Image equipementGO4;
    public Image equipementGO5;
    public Image equipementGO6;
    public static Main.Image[] dimensions;
    public static Main.Image[] locomotions;
    public static Main.Image[] equipements;

    private void RandomEqui()
    {
        Main.TabImage tab = Main.Global.TabE;
        int[] indices = { 0, 0, 0, 0, 0, 0 };
        bool allDiff = false;
        while (!allDiff)
        {
            indices[0] = Random.Range(0, tab.Taille);
            indices[1] = Random.Range(0, tab.Taille);
            indices[2] = Random.Range(0, tab.Taille);
            indices[3] = Random.Range(0, tab.Taille);
            indices[4] = Random.Range(0, tab.Taille);
            indices[5] = Random.Range(0, tab.Taille);
            allDiff = true;
            for (int i = 0; i < indices.Length - 1; i++)
            {
                for (int j = i + 1; j < indices.Length; j++)
                {
                    if (tab.getImageind(indices[i]).Sprite.Equals(tab.getImageind(indices[j]).Sprite))
                    {
                        allDiff = false;
                    }
                }
            }
        }
        equipements = new Main.Image[6];
        equipements[0] = tab.getImageind(indices[0]);
        equipements[1] = tab.getImageind(indices[1]);
        equipements[2] = tab.getImageind(indices[2]);
        equipements[3] = tab.getImageind(indices[3]);
        equipements[4] = tab.getImageind(indices[4]);
        equipements[5] = tab.getImageind(indices[5]);
        Main.Global.TabE.removeImage(equipements[0]);
        Main.Global.TabE.removeImage(equipements[1]);
        Main.Global.TabE.removeImage(equipements[2]);
        Main.Global.TabE.removeImage(equipements[3]);
        Main.Global.TabE.removeImage(equipements[4]);
        Main.Global.TabE.removeImage(equipements[5]);

        equipementGO1.sprite = equipements[0].Sprite;
        equipementGO2.sprite = equipements[1].Sprite;
        equipementGO3.sprite = equipements[2].Sprite;
    }

    private void RandomLoco()
    {
        int x = 0, y = 0, z = 0;
        Main.TabImage tab = Main.Global.TabL;
        while (tab.getImageind(x).Sprite.Equals(tab.getImageind(y).Sprite) || tab.getImageind(x).Sprite.Equals(tab.getImageind(z).Sprite) || tab.getImageind(z).Sprite.Equals(tab.getImageind(y).Sprite))
        {
            x = Random.Range(0, (tab.Taille - 1));
            y = Random.Range(0, (tab.Taille - 1));
            z = Random.Range(0, (tab.Taille - 1));
        }
        locomotions = new Main.Image[3];
        locomotions[0] = tab.getImageind(x);
        locomotions[1] = tab.getImageind(y);
        locomotions[2] = tab.getImageind(z);
        Main.Global.TabL.removeImage(locomotions[0]);
        Main.Global.TabL.removeImage(locomotions[1]);
        Main.Global.TabL.removeImage(locomotions[2]);

        locomotionGO1.sprite = locomotions[0].Sprite;
    }

    private void RandomDim()
    {
        int x = 0, y = 0, z = 0;
        Main.TabImage tab = Main.Global.TabD;
        while (tab.getImageind(x).Sprite.Equals(tab.getImageind(y).Sprite) || tab.getImageind(x).Sprite.Equals(tab.getImageind(z).Sprite) || tab.getImageind(z).Sprite.Equals(tab.getImageind(y).Sprite))
        {
            x = Random.Range(0, tab.Taille);
            y = Random.Range(0, tab.Taille);
            z = Random.Range(0, tab.Taille);
        }
        dimensions = new Main.Image[3];
        dimensions[0] = tab.getImageind(x);
        dimensions[1] = tab.getImageind(y);
        dimensions[2] = tab.getImageind(z);
        Main.Global.TabD.removeImage(dimensions[0]);
        Main.Global.TabD.removeImage(dimensions[1]);
        Main.Global.TabD.removeImage(dimensions[2]);

        dimensionGO1.sprite = dimensions[0].Sprite;
    }


    // Start is called before the first frame update
    void Start()
    {
        player = Main.Global.Player;
        Main.Global.addPlayer(player);

        Debug.Log(Main.Global.Player.ToString());
        
       
        Main.TabImage tab = Main.Global.TabD;
        text.text = "Joueur : " + player.Id;
        RandomDim();

        locomotions = new Main.Image[3];
        RandomLoco();

        RandomEqui();
    }



    public static Main.Image[] getLoco()
    {
        return locomotions;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
