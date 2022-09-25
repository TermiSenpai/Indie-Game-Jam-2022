using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmogusMove : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}