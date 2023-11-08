using UnityEngine;
public class NotfySounds : MonoBehaviour
{
    public AudioClip clip;
    public AudioClip cliptrue;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            MannagerAudio.instance.PlaySoundClip(clip, .4f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            MannagerAudio.instance.PlaySoundClip(cliptrue, .4f);
        }
    }
}

