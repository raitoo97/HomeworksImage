using UnityEngine;
using UnityEngine.UI;
public class MenuConfig : MonoBehaviour
{
    public Button startboton;
    public GameObject Pannel;
    private void Start()
    {
        startboton.onClick.AddListener(ButtonUse);
        var referencia = GameObject.FindObjectOfType<UIMannager>();
        referencia.StartCinematic += HiddenPannel;
        referencia.EndCinematic += ShowPannel;
        referencia.ShowWords += Saludar;
    }
    public void HiddenPannel()
    {
        Pannel.gameObject.SetActive(false);
    }
    public void ButtonUse()
    {
        var referencia = GameObject.FindObjectOfType<UIMannager>();
        referencia.OnStartCinematic();
        referencia.OnShowWords("Fasingo",50);
        var dolly = GameObject.FindObjectOfType<CinematicDolly>();
        dolly.CinematicPro();
    }
    public void ShowPannel()
    {
        Pannel.gameObject.SetActive(true);
    }
    public void Saludar(string Frase, int teset)
    {
        Debug.Log(Frase + teset);
    }
}
