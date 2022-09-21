using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AnimationBG : MonoBehaviour
{

    public Vector2 posicionInicio;
    public float anchoRepeticion;
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= anchoRepeticion)
            transform.position = posicionInicio;
    }
}
