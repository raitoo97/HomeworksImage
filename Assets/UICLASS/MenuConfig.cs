using System;
using UnityEngine;
using UnityEngine.UI;
public class MenuConfig : MonoBehaviour
{
    public Button startboton;
    public GameObject Pannel;
    private void Start()
    {
        startboton.onClick.AddListener(ButtonUse);
        var REFUI = GameObject.FindObjectOfType<UIMannager>();
        REFUI.ClosePannel += HiddenPannel;
        REFUI.ShowPannel += ShowPannel;
    }
    public void ButtonUse()
    {
        var dolly = GameObject.FindObjectOfType<CinematicDolly>();
        dolly.CinematicPro();
        var REFUI = GameObject.FindObjectOfType<UIMannager>();
        REFUI.OnHiddenPannel();
    }
    public void HiddenPannel()
    {
        Pannel.SetActive(false);
    }

    public void ShowPannel()
    {
        Pannel.SetActive(true);
    }
}
