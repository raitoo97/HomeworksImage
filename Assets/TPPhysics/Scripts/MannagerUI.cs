using UnityEngine;
using UnityEngine.UI;
public class MannagerUI : MonoBehaviour
{
    public static MannagerUI Instance;
    public Text time;
    public Text points;
    public Text finish_text;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        finish_text.gameObject.SetActive(false);
    }
    public void ChangeTime(float timer)
    {
        time.text = timer.ToString();
    }
    public void ChangeScore(int current_score)
    {
        points.text = current_score.ToString();
    }
    public void ShowFinishScreen()
    {
        finish_text.gameObject.SetActive(true);
    }
}
