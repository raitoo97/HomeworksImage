using UnityEngine;
public class CubeScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9)
        {
            var UIREF = GameObject.FindObjectOfType<MannagerUI>();
            UIREF.ChangeScoreText(1);
            Destroy(this.gameObject);
        }
    }
}
