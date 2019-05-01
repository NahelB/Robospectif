using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitPerso : MonoBehaviour
{
    public static Main.Player player;
    public Text text;
    public Image personnageGO1;
    public Image personnageGO2;
    public Image personnageGO3;
    public Image personnageGO4;
    public Image personnageGO5;
    public Image personnageGO6;
    public Image tick1;
    public Image tick2;
    public Image tick3;
    public Image tick4;
    public Image tick5;
    public Image tick6;
    private Image[] ticks;
    public static Main.Image[] personnages;
    private int nbJoueurs = Init.nbJoueurs;

    private void RandomPerso()
    {
        Main.TabImage tab = Main.Global.TabP;
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
        personnages = new Main.Image[6];
        personnages[0] = tab.getImageind(indices[0]);
        personnages[1] = tab.getImageind(indices[1]);
        personnages[2] = tab.getImageind(indices[2]);
        personnages[3] = tab.getImageind(indices[3]);
        personnages[4] = tab.getImageind(indices[4]);
        personnages[5] = tab.getImageind(indices[5]);
        Main.Global.TabE.removeImage(personnages[0]);
        Main.Global.TabE.removeImage(personnages[1]);
        Main.Global.TabE.removeImage(personnages[2]);
        Main.Global.TabE.removeImage(personnages[3]);
        Main.Global.TabE.removeImage(personnages[4]);
        Main.Global.TabE.removeImage(personnages[5]);

        personnageGO1.sprite = personnages[0].Sprite;
        personnageGO2.sprite = personnages[1].Sprite;
        personnageGO3.sprite = personnages[2].Sprite;
        personnageGO4.sprite = personnages[3].Sprite;
        personnageGO5.sprite = personnages[4].Sprite;
        personnageGO6.sprite = personnages[5].Sprite;
    }


    // Start is called before the first frame update
    void Start()
    {
        /*player = Main.Global.Player;
        Main.Global.addPlayer(player);*/

        //Debug.Log(Main.Global.Player.ToString());

        ticks = new Image[] { tick1, tick2, tick3, tick4, tick5, tick6 };
        for (int i = 0; i < ticks.Length; i++)
        {
            ticks[i].gameObject.SetActive(false);
        }

        Main.TabImage tab = Main.Global.TabD;
        text.text = "Joueur : " + selectUser.positionStatic;
        RandomPerso();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
