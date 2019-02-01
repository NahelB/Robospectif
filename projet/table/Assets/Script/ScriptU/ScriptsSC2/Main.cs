﻿using System;
using System.Collections;
using System.Xml.Linq;
using UnityEngine;

public class Main : MonoBehaviour
{
    public class Player
    {
        private int id;
        private int isSelect;
        private int place;
        private int idcarte1;
        private int idcarte2;
        private int idcarte3;
        private int isOk;

        public Player(int id, int isSelect, int place, int idcarte1, int idcarte2, int idcarte3, int isOk)
        {
            this.id = id;
            this.isSelect = isSelect;
            this.place = place;
            this.idcarte1 = idcarte1;
            this.idcarte2 = idcarte2;
            this.idcarte3 = idcarte3;
            this.isOk = isOk;
        }

        public Player()
        {
            this.id = 0;
            this.isSelect = 0;
            this.idcarte1 = 0;
            this.idcarte2 = 0;
            this.idcarte3 = 0;
            this.isOk = 0;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int IsSelect
        {
            get => isSelect;
            set => isSelect = value;
        }

        public int Place
        {
            get => place;
            set => place = value;
        }

        public int Idcarte1
        {
            get => idcarte1;
            set => idcarte1 = value;
        }

        public int Idcarte2
        {
            get => idcarte2;
            set => idcarte2 = value;
        }

        public int Idcarte3
        {
            get => idcarte3;
            set => idcarte3 = value;
        }

        public int IsOk
        {
            get => isOk;
            set => isOk = value;
        }

        public String ToString()
        {
            return "" + this.id.ToString() + this.isSelect.ToString() + this.place.ToString() +
                   this.idcarte1.ToString() + this.idcarte2.ToString() + this.idcarte3.ToString() +
                   this.isOk.ToString();
        }
    }

    public class Image
    {
        private int id;
        private Sprite sprite;


        public Image(int id, Sprite sprite)
        {
            this.id = id;
            this.sprite = sprite;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public Sprite Sprite
        {
            get => sprite;
            set => sprite = value;
        }
    }

    public class TabImage
    {
        private int taille;
        private Image[] tabsprite;


        public TabImage()
        {
            tabsprite = new Image[50];
            this.taille = 0;
        }

        public void addImage(Image image)
        {
            tabsprite[taille] = image;
            taille++;
        }

        public Image getImageind(int i)
        {
            return this.tabsprite[i];
        }

        public int getTaille()
        {
            return this.taille;
        }
    }

    public class Global
    {
        public static Player[] tabPlayer;
        private static int nbjoueur;
        private static TabImage tabL;
        private static TabImage tabD;
        private static TabImage tabE;


        public Global()
        {
            tabPlayer = new Main.Player[7];
            nbjoueur = 0;
            tabL = new TabImage();
            tabD = new TabImage();
            tabE = new TabImage();
        }

        public static Player[] TabPlayer
        {
            get => tabPlayer;
            set => tabPlayer = value;
        }

        public static int Nbjoueur
        {
            get => nbjoueur;
            set => nbjoueur = value;
        }

        public static TabImage TabL
        {
            get => tabL;
            set => tabL = value;
        }

        public static TabImage TabD
        {
            get => tabD;
            set => tabD = value;
        }

        public static TabImage TabE
        {
            get => tabE;
            set => tabE = value;
        }


        public static string ToString()
        {
            string res = "";
            for (int i = 1; i < 7; i++)
            {
                res = res + TabPlayer[i].ToString() + " ; ";
            }

            return res;
        }
    }

    // Start is called before the first frame update
   private TabImage tab;

    // Start is called before the first frame update
    void Start()
    {

        Global g = new Global();
        initializeLoco();
        initializeDi();
        initializeEqui();
        StartCoroutine(userInfo());

    }
    
    private  void initializeLoco()
    {
        tab = new TabImage();
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/LocomotionDos")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Ailes")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Ballon")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Chenilles")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Flottaison")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Helices")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Pattes")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Rampant")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Rebondir")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Locomotion/Roues")));
        Global.TabL = tab;

    }
    

    private  void initializeDi()
    {
        tab = new TabImage();
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/DosDimension")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/GrandeCapacite")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/GrandVegiculeLourd")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/GrandVehiculeIntermediaire")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/Monoplace")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/PetitRobot")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/TresGrandeCapacite")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/VehiculeIntermediaire")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/VehiculeLeger")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Dimension/VehiculeLourd")));
        Global.TabD = tab;

    }
    public  void initializeEqui()
    {
        tab = new TabImage();
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/EquipementDos.png")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/AppelUrgence")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/BrasArticules")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CameraThermique")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CanonPeinture")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CarrosserieReflechissante")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CentraleRecyclage")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CoffreBlinde")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/CommandeVocale")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/ConnexionVPN")));
        tab.addImage(new Image(tab.getTaille(), Resources.Load<Sprite>("image/Equipements/Couchettes")));
        Global.TabE = tab;

    }  

    // Update is called once per frame
    void Update()
    {
    }

    private static IEnumerator userInfo()
    {
        WWWForm logform = new WWWForm();
        var www = new WWW("https://primsie-spears.000webhostapp.com/select.php", logform);
        yield return www;

        string[] data = www.text.Split(new string[] {","}, System.StringSplitOptions.None);
        int x = 0;
        
        for (int i = 1; i < 7; i++)
        {
            Global.tabPlayer[i] = new Player(int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]),
                int.Parse(data[x++]), int.Parse(data[x++]), int.Parse(data[x++]));
    
        }

    }
}