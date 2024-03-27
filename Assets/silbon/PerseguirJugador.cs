using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerseguirJugador : MonoBehaviour
{
    public AudioSource silbidoAudioSource;
    public Transform player;
    public float speed = 3.0f;
    private bool waiting = false;

    void Start()
    {
        silbidoAudioSource.Play();
    }

    private void Update()
    {
        if (waiting){
            return;
        }
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    public void onPlayerHit() {
        generateRandomPosition();

        silbidoAudioSource.Stop();
        waiting = true;
        Invoke(nameof(SetWaitingFalse), 5);
    }

    void SetWaitingFalse()
    {
        silbidoAudioSource.Play();
        waiting = false;
    }

    private void generateRandomPosition()
    {
        float x = Random.Range(-10, 10);
        float z = Random.Range(-10, 10);
        transform.position = new Vector3(x, 0, z);
    }   
}
