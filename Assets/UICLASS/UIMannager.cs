using System;
using UnityEngine;
public class UIMannager : MonoBehaviour
{
    public Action ShowPannel;
    public Action ClosePannel;
    public void OnShowPannel()
    {
        ShowPannel?.Invoke();
    }
    public void OnHiddenPannel()
    {
        ClosePannel?.Invoke();
    }
}
