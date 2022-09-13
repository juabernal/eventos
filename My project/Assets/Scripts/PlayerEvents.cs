using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerEvents : MonoBehaviour
{
    public UnityEvent OnTriggerWin;
    public UnityEvent OnSoundVictory;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Ganaste!!!");
            OnTriggerWin?.Invoke();
            OnSoundVictory?.Invoke();
        }
    }

}
