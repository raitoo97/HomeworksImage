using UnityEngine;
using UnityEngine.UI;
public class PointsMannager : MonoBehaviour
{
    private int points_to_win;
    public Text points_text;
    private void Start()
    {
        var UIREF = GameObject.FindObjectOfType<MannagerUI>();
        UIREF.OnChangeScore += ChangeScore;
    }
    public void ChangeScore(int points)
    {
        points_to_win += points;
        points_text.text = points_to_win.ToString();
    }

}
