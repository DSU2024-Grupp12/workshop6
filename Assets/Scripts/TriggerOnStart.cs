using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerOnStart : MonoBehaviour
{
    private bool triggered;
    public UnityEvent onStart;
    
    // Start is called before the first frame update
    void Update()
    {
        if (!triggered)
        {
            onStart?.Invoke();
            triggered = true;
        }
    }
}
