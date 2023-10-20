using UnityEngine;
public class GameMannager : MonoBehaviour
{
    public static GameMannager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        TimeMannager.Instance.EndGame += FinishGame;
    }
    public  void FinishGame()
    {
        MannagerUI.Instance.ShowFinishScreen();
        var refpj = GameObject.FindObjectOfType<MovePj>();
        refpj.enabled = false;
        Time.timeScale = 0.0f;
    }
}
