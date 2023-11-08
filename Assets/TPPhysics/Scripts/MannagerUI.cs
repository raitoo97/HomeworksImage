using System;
using UnityEngine;
public class MannagerUI : MonoBehaviour
{
    public Action<int> OnChangeScore;
    public Action OnChangeTime;
    public Action OnFinishSceen;
    public void ChangeScoreText(int current_score)
    {
        OnChangeScore?.Invoke(current_score);
    }
    public void ChangeTimeText()
    {
        OnChangeTime?.Invoke();
    }
    public void OnFinishScreen()
    {
        OnFinishSceen?.Invoke();
    }
}
