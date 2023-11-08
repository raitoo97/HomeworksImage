using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Color FinalColor;
    public Color InitColor;
    public Slider imagen;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(FadeIn());
        }
    }

    IEnumerator FadeIn()
    {
        float time = 0;
        while (time < 1)
        {
            imagen.value = Mathf.Lerp(0, 1, time);
            yield return new WaitForSeconds(0.002f);
            time += Time.deltaTime;
            yield return null;
        }
    }
}
