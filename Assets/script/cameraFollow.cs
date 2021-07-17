using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform target;
    // What is the camera following?
    public float smoothing;
    // Dampening effect

    private Vector3 offset;
    // This will account for the position difference between the camera and the character.
    private float lowY;
    // The lowest point the camera can go (if the character falls off the screen)


    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
        lowY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetCamPos = target.position + offset;
        // This is where the camera wants to be
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
        // Lerp is a smoothing function “Linear Interpolation”
        if (transform.position.y < lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);

    }
}
