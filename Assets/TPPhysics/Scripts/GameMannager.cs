using UnityEngine;
public class GameMannager : MonoBehaviour
{
    private int points_to_win;
    public static GameMannager Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        points_to_win = 0;
    }
    public  void ChangeScore(int points)
    {
        points_to_win += points;
    }
}
