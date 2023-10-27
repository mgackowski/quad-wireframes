using UnityEngine;

/**
 * A very simple script to help showcase the effect in motion.
 * **/
public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 0.1f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
    }
}