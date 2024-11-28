using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVENT : MonoBehaviour
{
    public float speed = 30f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime));
    }
}
