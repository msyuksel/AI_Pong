using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{
    //Currently a script attatched to the Canvas of the UI

    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("Canvas");
        DontDestroyOnLoad(this.gameObject);
    }
}
