﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject road;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -11)
        {
            Instantiate(road, new Vector3(0.029f, 18f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
