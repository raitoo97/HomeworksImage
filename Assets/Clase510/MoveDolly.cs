using Cinemachine;
using System.Collections;
using UnityEngine;
public class MoveDolly : MonoBehaviour
{
    public CinemachineVirtualCamera CinmeachineCamera;
    private void Start()
    {
        StartCoroutine(StartDolly());
    }
    IEnumerator StartDolly()
    {
        float recorrido = 0.0f;
        while(recorrido < 1)
        {
            CinmeachineCamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = recorrido;
            yield return new WaitForSeconds(0.1f);
            recorrido += Time.deltaTime;
        }
    }
 
}
