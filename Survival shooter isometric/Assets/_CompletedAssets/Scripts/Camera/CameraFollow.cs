using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f; //Adds some lag to make smoother transitions, 5f is the value for it

    Vector3 offset; //store distance for offset for each update

    void Start()
    {
        offset = transform.position - target.position; //difference from camera postion to player postion
    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset; // target camera position which is the camera postion plus its offset
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime); //Moves towards target postion and how fast to do this
    }
}