using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyUI : MonoBehaviour
{
    public RenderMode renderMode { get; internal set; }

    //Currently a script attatched to the Canvas of the UI

    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("Canvas");
        DontDestroyOnLoad(this.gameObject);
    }
}
