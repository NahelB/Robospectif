using System;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ChangeImageEqui : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public bool[] selection;
    public Image image;
    public Main.Image[] equi;
    private int indice;
    private Main.Player p;

    // Start is called before the first frame update
    void Start()

    {
        equi = MainScript.equipements;
        selection = Equipement.selection;
        indice = 0;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        image.sprite = equi[Equipement.TraiteIndice()].Sprite;
    }
}
