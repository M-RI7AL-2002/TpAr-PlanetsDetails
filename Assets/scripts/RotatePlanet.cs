using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotateSpeed = 40f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))  // press 'I' key
        {
          rotateSpeed=rotateSpeed+20;
        }
        if (Input.GetKeyDown(KeyCode.B))  // press 'I' key
        {
            rotateSpeed = rotateSpeed - 20;
            if (rotateSpeed < 0) rotateSpeed = 0;
        }
        if (Input.GetKeyDown(KeyCode.O))  // press 'I' key
        {
          rotateSpeed = 0;
        }
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

    }
}
