using System.Collections.Generic;
using UnityEngine;
public class MannagerAudio : MonoBehaviour
{
    public static MannagerAudio instance;
    public List<AudioClip> clips;
    public List<AudioSource> sources;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        CompletePool(5);
        LoadResources();
    }
    private void CompletePool(int num)
    {
        for(int i = 0; i < num; i++)
        {
            AddSources();
        }
    }
    private void AddSources()
    {
        AudioSource source = this.gameObject.AddComponent<AudioSource>();
        sources.Add(source);
    }
    private AudioSource GetAudioSurce()
    {
        return sources.Find(x => x.isPlaying == false);
    }
    private void LoadResources()
    {
        var clipsResources = Resources.LoadAll<AudioClip>("Audios");
        foreach(AudioClip clip in clipsResources)
        {
            clips.Add(clip);
        }
    }
    public void PlaysoundByName(string name,float volumen)
    {
        AudioSource source = GetAudioSurce();
        if(source != null)
        {
            source.volume = volumen;
            var clip = clips.Find(x => x.name == name);
            source.clip = clip;
            source.Play();
        }
    }
    public void PlaySoundClip(AudioClip clip,float volumen)
    {
        AudioSource source = GetAudioSurce();
        if (source != null)
        {
            source.volume = volumen;
            var findclip = clips.Find(x => x.name == clip.name);
            if(findclip != null)
            {
                source.clip = clip;
                source.Play();
            }
            else
            {
                Debug.Log("NO");
            }

        }
    }
}
