using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private GameObject player;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 goalDirection = (player.transform.position - transform.position).normalized;
        // Follow the player
        // Normalized - so that the magnitude won't increase with respect to the enemys distance from the player 
        playerRb.AddForce(goalDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
