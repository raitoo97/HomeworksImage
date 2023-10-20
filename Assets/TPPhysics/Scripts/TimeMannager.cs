using System;
using System.Collections;
using UnityEngine;
public class TimeMannager : MonoBehaviour
{
    public static TimeMannager Instance;
    public float time;
    public Action EndGame;
    private Coroutine corrutine_time;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        time = 0.0f;
    }
    private void Start()
    {
        StartTimeCoroutine();
    }
    public void StartTimeCoroutine()
    {
        corrutine_time = StartCoroutine(TimeEnd(20.0f));
    }
    public void StopTimeCoroutine()
    {
        StopCoroutine(corrutine_time);
    }
    IEnumerator TimeEnd(float finish_time)
    {
        time = 0;
        while (time < finish_time)
        {
            time = Time.time;
            MannagerUI.Instance.ChangeTime(time);
            yield return null;
        }
        EndGame.Invoke();
    }
}
