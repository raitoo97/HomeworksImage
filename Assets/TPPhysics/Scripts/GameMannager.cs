using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class GameMannager : MonoBehaviour
{
    MannagerUI RefUi;
    public Text finish_text;
    private void Start()
    {
        RefUi = GameMannager.FindObjectOfType<MannagerUI>();
        var condition = RefUi != null;
        condition = (condition = true ? true : false);
        if (condition)
        {
            StartCoroutine(Controltime());
            RefUi.OnFinishSceen += FinishGame;
        }
    }
    IEnumerator Controltime()
    {
        while (true)
        {
            RefUi.ChangeTimeText(0);
            yield return null;
        }
    }
    public  void FinishGame()
    {
        finish_text.gameObject.SetActive(true);
        var refpj = GameObject.FindObjectOfType<MovePj>();
        refpj.enabled = false;
        Time.timeScale = 0.0f;
    }
}
