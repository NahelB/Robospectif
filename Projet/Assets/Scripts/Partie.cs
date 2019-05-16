using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partie
{

    private Joueur[] joueurs;
    private int tour;

    public Partie()
    {
        tour = 1;
        joueurs = new Joueur[6];
    }

    public Joueur[] Joueurs
    {
        get => joueurs;
        set => joueurs = value;
    }

    public int Tour
    {
        get => tour;
        set => tour = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
