// using System;
using UnityEngine;
using UnityEngine.Events;

public class PendeteksiInput : MonoBehaviour
{
    public UnityEvent inputEvent;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputEvent.Invoke();
        }
    }
}
