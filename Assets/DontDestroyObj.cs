using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObj : MonoBehaviour
{
    void Start()
    {
        GameObject objs = GameObject.FindGameObjectWithTag("GameplayObj");
        DontDestroyOnLoad(this.gameObject);
    }
}
