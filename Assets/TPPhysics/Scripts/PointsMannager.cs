using UnityEngine;
public class PointsMannager : MonoBehaviour
{
    public static PointsMannager Instance;
    private int points_to_win;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        points_to_win = 0;
    }
    public void ChangeScore(int points)
    {
        points_to_win += points;
        MannagerUI.Instance.ChangeScore(points_to_win);
        print(points_to_win);
    }
}
