using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        // Reference: Local coordinates (World/Default)
        //playerRb.AddForce(Vector3.forward * speed * forwardInput);

        // Reference: Global coordinates (Focal Point)
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
