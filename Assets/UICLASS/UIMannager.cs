using System;
using UnityEngine;

public class UIMannager : MonoBehaviour
{
    public Action StartCinematic;
    public Action EndCinematic;
    public Action<string,int>ShowWords;
    public void OnStartCinematic()
    {
        StartCinematic?.Invoke();
    }
    public void OnEndCinematic()
    {
        EndCinematic?.Invoke();
    }
    public void OnShowWords(string word,int teset)
    {
        ShowWords?.Invoke(word, teset);
    }


}
