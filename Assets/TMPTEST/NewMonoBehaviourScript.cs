using UnityEngine;
using System.Collections;
using System;

public class NewMonoBehaviourScript : MonoBehaviour
{
      public event Action OnTick;
    void Start()
    {
        StartCoroutine(Timer());
    }
    
    IEnumerator Timer()
    {
        while (true)
        {
            Debug.Log("TICK");
            
            OnTick?.Invoke();
            
            yield return new WaitForSeconds(1);
        }
    }
}
