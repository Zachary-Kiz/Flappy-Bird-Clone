using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLogic : MonoBehaviour
{
    private Transform pipe;
    public float pipeVelocity;
    // Start is called before the first frame update
    void Start()
    {
        pipe = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!GlobalVars.gameOver)
        {
            pipe.position += Vector3.left * pipeVelocity * Time.deltaTime;
        }
    }
}
