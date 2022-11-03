using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class MyExample01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(WaitTime());
        WaitTimeAsync().SuppressCancellationThrow();
    }

    IEnumerator WaitTime()
    {
        Debug.Log("等会");
        yield return new WaitForSeconds(2);
        Debug.Log("你好");
    }

    private async UniTask WaitTimeAsync()
    {
        Debug.Log("等会");
        await UniTask.Delay(TimeSpan.FromSeconds(2));
        Debug.Log("你好");
    }
}