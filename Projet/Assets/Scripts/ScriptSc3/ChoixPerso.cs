using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoixPerso : MonoBehaviour, IPointerClickHandler
{
    public Image image;
    public Image tick1;
    public Image tick2;
    public Image tick3;
    public Image tick4;
    public Image tick5;
    public Image tickCurrent;
    public Button button;
    private Image[] ticks;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => ButtonClicked());
        ticks = new Image[] { tick1, tick2, tick3, tick4, tick5};
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        tickCurrent.gameObject.SetActive(true);
        for (int i = 0; i < ticks.Length; i++)
        {
            ticks[i].gameObject.SetActive(false);
        }
    }
    private void ButtonClicked()
    {
        if (tickCurrent.gameObject.active)
        {
            ValiderPerso.perso = image.sprite;
        }
        SceneManager.LoadScene("scene4");
    }
}
