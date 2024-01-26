using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Déplacement : MonoBehaviour
{
    public float speed = 5;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}