using System;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class User2main : MonoBehaviour
{
    public static Sprite picl0;
    public static Sprite picl1;
    public static Sprite picl2;
    public static Sprite picl3;
    public static Sprite picl4;
    public static Sprite picl5;
    public static Sprite picl6;
    public static Sprite picl7;
    public static Sprite picl8;
    public static Sprite picl9;

    public static Sprite picd0;
    public static Sprite picd1;
    public static Sprite picd2;
    public static Sprite picd3;
    public static Sprite picd4;
    public static Sprite picd5;
    public static Sprite picd6;
    public static Sprite picd7;
    public static Sprite picd8;
    public static Sprite picd9;
    
    public static Sprite pice0;
    public static Sprite pice1;
    public static Sprite pice2;
    public static Sprite pice3;
    public static Sprite pice4;
    public static Sprite pice5;
    public static Sprite pice6;
    public static Sprite pice7;
    public static Sprite pice8;
    public static Sprite pice9;

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;

    public Image image11;
    public Image image12;
    public Image image13;
    public Image image14;
    public Image image15;
    public Image image16;

    public Image image111;
    public Image image112;
    public Image image113;
    
    public Image image121;
    public Image image122;
    public Image image123;
    
    public Image image131;
    public Image image132;
    public Image image133;
    
    public Image image141;
    public Image image142;
    public Image image143;
    
    public Image image151;
    public Image image152;
    public Image image153;
    
    public Image image161;
    public Image image162;
    public Image image163;
    

    public Image[] imagetab;
    public Image[] imagetab1;

    public Vector2[] vector2;

    public static Sprite[] picl;
    public static Sprite[] picd;
    public static Sprite[] pice;

    void Start()
    {
        vector2 = new Vector2[sc._nbjoueur];
        imagetab = new Image[] {image1, image2, image3, image4, image5, image6};
        imagetab1 = new Image[] {image11, image12, image13, image14, image15, image16};

        int i = 0;

        if (b1.estselec == 1)
        {
            vector2[i] = sc._position1;
            i++;
        }
        else
        {
            Destroy(image111);
            Destroy(image112);
            Destroy(image113);

        }

        if (b2.estselec == 1)
        {
            vector2[i] = sc._position2;
            i++;
        }
        else
        {
            Destroy(image121);
            Destroy(image122);
            Destroy(image123);
        } 
           

        if (b3.estselec == 1)
        {
            vector2[i] = sc._position3;
            i++;
        }else
        {
            Destroy(image131);
            Destroy(image132);
            Destroy(image133);
        } 

        if (b4.estselec == 1)
        {
            vector2[i] = sc._position4;
            i++;
        }else
        {
            Destroy(image141);
            Destroy(image142);
            Destroy(image143);
        } 
        if (b5.estselec == 1)
        {
            vector2[i] = sc._position5;
            i++;
        }else
        {
            Destroy(image151);
            Destroy(image152);
            Destroy(image153);
        } 

        if (b6.estselec == 1)
        {
            vector2[i] = sc._position6;
            i++;
        }else
        {
            Destroy(image161);
            Destroy(image162);
            Destroy(image163);
        } 


        image1.transform.position = vector2[0];
        image2.transform.position = vector2[1];
        image3.transform.position = vector2[2];
        image4.transform.position = vector2[3];

        image11.transform.position = vector2[0];
        image12.transform.position = vector2[1];
        image13.transform.position = vector2[2];
        image14.transform.position = vector2[3];
        if (sc._nbjoueur == 4)
        {
            Destroy(image5);
            Destroy(image6);

            Destroy(image15);
            Destroy(image16);
        }

        else if (sc._nbjoueur == 5)
        {
            image5.transform.position = vector2[4];
            Destroy(image6);

            image15.transform.position = vector2[4];
            Destroy(image16);
        }
        else if (sc._nbjoueur == 6)
        {
            image5.transform.position = vector2[4];
            image6.transform.position = vector2[5];

            image15.transform.position = vector2[4];
            image16.transform.position = vector2[5];
        }


       for (i = 0; i < 6; i++)
        {
            {
                if ((imagetab[i].transform.position.Equals(sc._position4)  ) || (imagetab[i].transform.position.Equals(sc._position5)  ))
                {
                    imagetab[i].transform.Rotate(Vector3.forward * -180);
                    imagetab1[i].transform.Translate(185,0,0);
                    imagetab1[i].transform.Rotate(Vector3.forward * -180);


                }


                else if (imagetab[i].transform.position.Equals(sc._position3))
                {
                    imagetab[i].transform.Rotate(Vector3.forward * -90);
                    imagetab1[i].transform.Translate(0,-200,0);

                    imagetab1[i].transform.Rotate(Vector3.forward * -90);


                }
                else if (imagetab[i].transform.position.Equals(sc._position6))
                {
                    imagetab[i].transform.Rotate(Vector3.forward * 90);
                    imagetab1[i].transform.Translate(0,-200,0);
                    imagetab1[i].transform.Rotate(Vector3.forward * 90);



                }
                else
                {
                    imagetab1[i].transform.Translate(185,0,0);

                }
            }
        }
    }

    public static Sprite[] getSpritel()
    {
        init();
        return picl;
    }

    public static Sprite[] getSprited()
    {
        init2();
        return picd;
    }
    
    public static Sprite[] getSpritee()
    {
        init3();
        return pice;
    }

    public static void init()
    {
        picl1 = Resources.Load<Sprite>("image/Locomotion/Ailes");
        picl2 = Resources.Load<Sprite>("image/Locomotion/Ballon");
        picl3 = Resources.Load<Sprite>("image/Locomotion/Chenilles");
        picl4 = Resources.Load<Sprite>("image/Locomotion/Flottaison");
        picl5 = Resources.Load<Sprite>("image/Locomotion/Helices");
        picl6 = Resources.Load<Sprite>("image/Locomotion/Pattes");
        picl7 = Resources.Load<Sprite>("image/Locomotion/Rampant");
        picl8 = Resources.Load<Sprite>("image/Locomotion/Rebondir");
        picl9 = Resources.Load<Sprite>("image/Locomotion/Roues");
        picl0 = Resources.Load<Sprite>("image/Locomotion/LocomotionDos");
        picl = new Sprite[9] {picl1, picl2, picl3, picl4, picl5, picl6, picl7, picl8, picl9};
    }

    public static void init2()
    {
        picd1 = Resources.Load<Sprite>("image/Dimension/GrandeCapacite");
        picd2 = Resources.Load<Sprite>("image/Dimension/GrandVegiculeLourd");
        picd3 = Resources.Load<Sprite>("image/Dimension/GrandVehiculeIntermediaire");
        picd4 = Resources.Load<Sprite>("image/Dimension/Monoplace");
        picd5 = Resources.Load<Sprite>("image/Dimension/PetitRobot");
        picd6 = Resources.Load<Sprite>("image/Dimension/TresGrandeCapacite");
        picd7 = Resources.Load<Sprite>("image/Dimension/VehiculeIntermediaire");
        picd8 = Resources.Load<Sprite>("image/Dimension/VehiculeLeger");
        picd9 = Resources.Load<Sprite>("image/Dimension/VehiculeLourd");
        picd0 = Resources.Load<Sprite>("image/Dimension/DosDimension");
        picd = new Sprite[9] {picd1, picd2, picd3, picd4, picd5, picd6, picd7, picd8, picd9};
    }
    
    public static void init3()
    {
        pice1 = Resources.Load<Sprite>("image/Equipements/AppelUrgence");
        pice2 = Resources.Load<Sprite>("image/Equipements/BrasArticules");
        pice3 = Resources.Load<Sprite>("image/Equipements/CameraThermique");
        pice4 = Resources.Load<Sprite>("image/Equipements/CanonPeinture");
        pice5 = Resources.Load<Sprite>("image/Equipements/CarrosserieReflechissante");
        pice6 = Resources.Load<Sprite>("image/Equipements/CentraleRecyclage");
        pice7 = Resources.Load<Sprite>("image/Equipements/CoffreBlinde");
        pice8 = Resources.Load<Sprite>("image/Equipements/CommandeVocale");
        pice9 = Resources.Load<Sprite>("image/Equipements/ConnexionVPN");
        pice0 = Resources.Load<Sprite>("image/Equipements/EquipementDos");
        pice = new Sprite[9] {pice1, pice2, pice3, pice4, pice5, pice6, pice7, pice8, pice9};
    }
}