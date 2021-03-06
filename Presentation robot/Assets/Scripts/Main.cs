﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public class Player
    {
        private int id;
        private int place;
        private int idcarte1;
        private int idcarte2;
        private int idcarte3;
        private int idcarte4;
        private int idcarte5;

        public Player(int id, int place, int idcarte1, int idcarte2, int idcarte3, int idcarte4, int idcarte5)
        {
            this.id = id;
            this.place = place;
            this.idcarte1 = idcarte1;
            this.idcarte2 = idcarte2;
            this.idcarte3 = idcarte3;
            this.idcarte4 = idcarte4;
            this.idcarte5 = idcarte5;

        }

        public Player(int id)
        {
            this.id = id;
            this.idcarte1 = 0;
            this.idcarte2 = 0;
            this.idcarte3 = 0;
            this.idcarte4 = 0;
            this.idcarte5 = 0;
        }

        public Player()
        {
            this.id = 0;
            this.idcarte1 = 0;
            this.idcarte2 = 0;
            this.idcarte3 = 0;
            this.idcarte4 = 0;
            this.idcarte5 = 0;
        }

        public int Id
        {
            get => id;
            set => id = value;
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

        public int Idcarte4
        {
            get => idcarte4;
            set => idcarte4 = value;
        }

        public int Idcarte5
        {
            get => idcarte5;
            set => idcarte5 = value;
        }


        public String ToString()
        {
            return "" + this.id.ToString() +  this.place.ToString() +
                   this.idcarte1.ToString() + this.idcarte2.ToString() + this.idcarte3.ToString() ;
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
        private List<Image> tabsprite;


        public TabImage()
        {
            tabsprite = new List<Image>();
            this.taille = 0;
        }

        public void addImage(Image image)
        {
            tabsprite.Add(image);
            taille++;
        }

        public void removeImage(Image image)
        {
            tabsprite.Remove(image);
            taille--;
        }

        public int Taille
        {
            get => taille;
            set => taille = value;
        }

        public List<Image> Tabsprite
        {
            get => tabsprite;
            set => tabsprite = value;
        }

        public Image getImageind(int i)
        {
            return this.tabsprite[i];
        }

        public void toString()
        {
            for (int i = 0; i < this.Taille; i++)
            {
                Debug.Log(getImageind(i));
            }
        }
    }

    public class Global
    {
        private static Player player;
        private static TabImage tabL;
        private static TabImage tabD;
        private static TabImage tabE;
        public static Player[] tabPlayer;
        private static int nbjoueur;

        public Global()
        {
            player = new Player();
            tabL = new TabImage();
            tabD = new TabImage();
            tabE = new TabImage();
            tabPlayer = new Main.Player[7];
            nbjoueur = 0;
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

        public void SetPlayerT(Player[] p)
        {
            tabPlayer = p;
        }

        public static void Setnbjoueur(int i)
        {
            nbjoueur = i;
        }
        public static void addPlayer(Player p)
        {
            tabPlayer[nbjoueur] = p;
            nbjoueur++;
        }


        public static Player Player
        {
            get => player;
            set => player = value;
        }

        public void SetPlayer(Player p)
        {
            player = p;
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

#pragma warning disable CS0114 // Un membre masque un membre hérité ; le mot clé override est manquant
        public static string ToString()
#pragma warning restore CS0114 // Un membre masque un membre hérité ; le mot clé override est manquant
        {
            string res = "";
            for (int i = 1; i < 7; i++)
            {
                res = res + TabPlayer[i].ToString() + " ; ";
            }

            return res;
        }
    }

    private TabImage tab;

    // Start is called before the first frame update
    void Start()
    {

        Global g = new Global();
        g.SetPlayer( new Player(1, 4, 8, 8, 7, 2, 8));

        initializeLoco();
        initializeDi();
        initializeEqui();

    }

    private void initializeLoco()
    {
        tab = new TabImage();
        for (int i = 0; i < 2; i++)
        {
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Ailes")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Ballon")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Chenilles")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Flottaison")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Helices")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Pattes")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Rampant")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Rebondir")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Locomotion/Roues")));
        }
        Global.TabL = tab;

    }


    private void initializeDi()
    {
        tab = new TabImage();
        for (int i = 0; i < 2; i++)
        {
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/GrandeCapacite")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/GrandVehiculeLourd")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/GrandVehiculeIntermediaire")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/Monoplace")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/PetitRobot")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/TresGrandeCapacite")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/VehiculeIntermediaire")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/VehiculeLeger")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Dimension/VehiculeLourd")));
        }
        Global.TabD = tab;

    }
    public void initializeEqui()
    {
        tab = new TabImage();
        for (int i = 0; i < 2; i++)
        {
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/AppelUrgence")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/BrasArticules")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/CameraThermique")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/CanonPeinture")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/CarrosserieReflechissante")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/CentraleRecyclage")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/CoffreBlinde")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/CommandeVocale")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/ConnexionVPN")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Couchettes")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Cuisine")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/DetecteurFumeeGaz")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Eoliennes")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/EquipementsFitness")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/FlotteDecentralisee")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/FuseeDetresse")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Imprimante3D")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Joker")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/KitReparation")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/KitSoinsUrgences")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/LaboratoireAnalyses")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Minibar")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/OutillageChantier")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/PanneauxSolaires")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/PanneauxVideos")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/ProjectionHolographique")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/RampeAcces")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/SiegeEjectable")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Sonar")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/SondesMesures")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/StationJeu")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/StudioEnregistrement")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/SystemeArrosage")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/SystemeEcoute")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Toboggan")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/TVSatellite")));
            tab.addImage(new Image(tab.Taille, Resources.Load<Sprite>("image/Equipements/Ventouses")));
        }
        Global.TabE = tab;

    }
}
