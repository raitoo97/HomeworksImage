using UnityEngine;
public class MoveSphere : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            float getaxis = Input.GetAxis("Vertical");
            this.transform.Translate(0.0f,0.0f , getaxis * Time.deltaTime * 50.0f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            float getaxis = Input.GetAxis("Horizontal");
            this.transform.Rotate(0.0f, getaxis * Time.deltaTime * 50.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
        {
            float getaxis = Input.GetAxis("UpDown");
            this.transform.Translate(0.0f, getaxis * Time.deltaTime * 50.0f,0.0f);
        }
    }
}
