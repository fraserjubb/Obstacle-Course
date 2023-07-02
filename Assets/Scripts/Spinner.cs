using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAxis = 0f;
    [SerializeField] float yAxis = 0.5f;
    [SerializeField] float zAxis = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAxis, yAxis, zAxis);
    }
}
