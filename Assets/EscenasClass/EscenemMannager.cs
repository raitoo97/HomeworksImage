using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenemMannager : MonoBehaviour
{
    public static EscenemMannager instance;
    [SerializeField]private List<string> Scenes;
    [SerializeField]private List<string> ScenesLoaded;
    public List<string> GetScenesLoaded {  get => ScenesLoaded; }
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
        DontDestroyOnLoad(gameObject);
        Scenes = new List<string>();
    }
    private void Start()
    {
        Scenes.Add("Escena2");
        Scenes.Add("Escena3");
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OpenBatchesAsyncScene(Scenes);
        }
        if (Input.GetMouseButtonDown(1))
        {
            UnloadMutipleScene(Scenes);
        }
    }
    private void OpenSyncScene(string name)
    {
        SceneManager.LoadScene(name, LoadSceneMode.Single);
        ScenesLoaded.Add(name);
    }
    private void OpenSyncSceneAditive(string name)
    {
        SceneManager.LoadScene(name,LoadSceneMode.Additive);
        ScenesLoaded.Add(name);
    }
    private void OpenAsyncScene(string name)
    {
        var Corutine = StartCoroutine(AsyncSceneCorrutine(name));
        ScenesLoaded.Add(name);
    }
    public void OpenAsyncSceneAditive(string name)
    {
        var Corutine = StartCoroutine(AsyncSceneCorrutineAditive(name));
        ScenesLoaded.Add(name);
    }
    private void OpenBatchesSyncScenes(List<string> Escenes)
    {
        foreach (var scene in Escenes)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Additive);
            ScenesLoaded.Add(scene);
        }
    }
    private void OpenBatchesAsyncScene(List<string> Escenes)
    {
        var courrtine = StartCoroutine(OpenBatchesAsyncSceneCorrutine(Escenes));
    }
    IEnumerator AsyncSceneCorrutine(string name)
    {
        AsyncOperation OpenAsynScene = SceneManager.LoadSceneAsync(name);
        while (!OpenAsynScene.isDone)
        {
            Debug.Log("Progress: " + OpenAsynScene.progress);
            yield return null;
        }
    }
    IEnumerator AsyncSceneCorrutineAditive(string name)
    {
        AsyncOperation OpenAsynScene = SceneManager.LoadSceneAsync(name,LoadSceneMode.Additive);
        while (!OpenAsynScene.isDone)
        {
            Debug.Log("Progress: " + OpenAsynScene.progress);
            yield return null;
        }
    }
    IEnumerator OpenBatchesAsyncSceneCorrutine(List<string> Escenes)
    {
        foreach (var scene in Escenes)
        {
            AsyncOperation asynscenes = SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
            ScenesLoaded.Add(scene);
            while (!asynscenes.isDone)
            {
                Debug.Log("Cargando: " + asynscenes.progress);
                yield return null;
            }
        }
    }

    private void UnloadSimpleScene(string name)
    {
        var Courrtine = StartCoroutine(UnloadSimpleSceneCorrutine(name));
    }
    IEnumerator UnloadSimpleSceneCorrutine(string name)
    {
        if (ScenesLoaded.Contains(name))
        {
            AsyncOperation UnloadAsync = SceneManager.UnloadSceneAsync(name, UnloadSceneOptions.None);
            ScenesLoaded.Remove(name);
            while(!UnloadAsync.isDone)
            {
                Debug.Log("Remove Scene: " + UnloadAsync.progress);
                yield return null;
            }
        }
    }
    //Descargar escenas multiples
    private void UnloadMutipleScene(List<string> Escenes)
    {
        var Courrtine = StartCoroutine(UnloadMutipleSceneCorrutine(Escenes));
    }
    IEnumerator UnloadMutipleSceneCorrutine(List<string> Escenes)
    {
        foreach (var Escene in Escenes) 
        {
            if (ScenesLoaded.Contains(Escene))
            {
                AsyncOperation UnloadAsync = SceneManager.UnloadSceneAsync(Escene, UnloadSceneOptions.None);
                ScenesLoaded.Remove(Escene);
                while (!UnloadAsync.isDone)
                {
                    Debug.Log("Remove Scene: " + UnloadAsync.progress);
                    yield return null;
                }
            }
        }
        
    }
}
