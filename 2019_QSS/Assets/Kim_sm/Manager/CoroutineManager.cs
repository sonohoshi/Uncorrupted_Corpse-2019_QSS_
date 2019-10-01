using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager : MonoBehaviour
{
    public static CoroutineManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Coroutine StartCoroutine(Coroutine coroutine)
    {
        return StartCoroutine(coroutine);
    }
}
