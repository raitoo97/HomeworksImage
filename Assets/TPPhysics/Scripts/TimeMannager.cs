using UnityEngine;
using UnityEngine.UI;
public class TimeMannager : MonoBehaviour
{
    public float time;
    public Text time_text;
    private void Start()
    {
        var REFUI = GameObject.FindObjectOfType<MannagerUI>();
        REFUI.OnChangeTime += StartedTime;
    }
    public void StartedTime(float current_time)
    {
        float real_time = Time.time;
        current_time = real_time;
        time = current_time;
        time_text.text = time.ToString();
        if(time >= 5)
        {
            var RefMannagerUI = GameMannager.FindObjectOfType<MannagerUI>();
            var condition = RefMannagerUI != null;
            condition = true? true: false;
            if(condition)
            {
                RefMannagerUI.OnFinishScreen();
            }
        }
    }
}
