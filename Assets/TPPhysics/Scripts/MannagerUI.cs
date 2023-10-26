using System;
using UnityEngine;
public class MannagerUI : MonoBehaviour
{
    public Action<int> OnChangeScore;
    public Action<float> OnChangeTime;
    public Action OnFinishSceen;
    public void ChangeScoreText(int current_score)
    {
        OnChangeScore?.Invoke(current_score);
    }
    public void ChangeTimeText(float finish_time)
    {
        OnChangeTime?.Invoke(finish_time);
    }
    public void OnFinishScreen()
    {
        OnFinishSceen?.Invoke();
    }
}
