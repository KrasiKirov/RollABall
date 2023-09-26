using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float minHeight = 0.5f; // Minimum height of the sine wave
    [SerializeField] private float maxHeight = 1.5f; // Maximum height of the sine wave
    [SerializeField] private float speed = 1f; // Speed of the movement

    private Vector3 startPosition;
    private float amplitude;

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the amplitude of the sine wave
        amplitude = (maxHeight - minHeight) / 2;

        // Set the starting position of the cube to the midpoint of minHeight and maxHeight
        startPosition = transform.position;
        startPosition.y = minHeight + amplitude;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        // Calculate the new position based on the sine wave
        float newYPosition = startPosition.y + Mathf.Sin(Time.time * speed) * amplitude;

        // Update the position of the cube
        transform.position = new Vector3(startPosition.x, newYPosition, startPosition.z);
    }
}

