using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision : MonoBehaviour
{

    public UnityEvent OnDead;
    public UnityEvent SoundGameOver;
    public UnityEvent Choque;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Chocaste contra enemigo");
            Choque?.Invoke();

            GameManager.VidaPlayer--;
            Debug.Log(GameManager.VidaPlayer);
            if (GameManager.VidaPlayer == 0)

            {
                Destroy(gameObject);
                OnDead?.Invoke();
                SoundGameOver?.Invoke();
                
            }
        }
    }
}
