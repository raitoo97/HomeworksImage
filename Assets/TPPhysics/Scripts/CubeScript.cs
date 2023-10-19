using UnityEngine;
public class CubeScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9)
        {
            print("Si");
        }
    }
}
