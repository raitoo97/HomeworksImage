using Cinemachine;
using System.Collections;
using UnityEngine;
public class CinematicDolly : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public void CinematicPro()
    {
        StartCoroutine(MoveCinematic());
    }
    IEnumerator MoveCinematic()
    {
        float recorrido = 0.0f;
        while(recorrido < 1)
        {
            virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>().m_PathPosition = recorrido;
            yield return new WaitForSeconds(.1f);
            recorrido += Time.deltaTime * 5;
        }
        var referencia = GameObject.FindObjectOfType<UIMannager>();
        referencia.OnEndCinematic();

    }
}
