using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipe : MonoBehaviour
{
    [SerializeField]
    private float maxTime = 1.4f;
    [SerializeField]
    private float height = 1.5f;
    [SerializeField]
    private float timer = 0f;
    [SerializeField]
    private GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (timer>maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            Destroy(newPipe, 10f);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
