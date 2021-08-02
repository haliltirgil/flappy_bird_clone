using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        movePipe();   
    }

    private void movePipe()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
