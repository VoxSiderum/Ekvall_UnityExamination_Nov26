using UnityEngine;
using UnityEngine.Events;

public class CustomUnityEvent : MonoBehaviour
{
    public UnityEvent onStart, onTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onStart.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        onTrigger.Invoke();
    }
}
