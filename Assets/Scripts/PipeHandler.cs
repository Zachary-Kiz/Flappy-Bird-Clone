using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeHandler : MonoBehaviour
{
    public GameObject dupPipe;
    public float spawnTime;
    private float timer;
    private float prevHeight = 0;
    private int minHeight = -4;
    private int maxHeight = 0;

    // Update is called once per frame
    void Update()
    {
        if (!GlobalVars.hasStarted || GlobalVars.gameOver) return;

        timer += Time.deltaTime;

        if (timer > spawnTime)
        {
            GameObject clonePipe = Instantiate(dupPipe);
            Transform pipeTrans = clonePipe.transform;
            Vector3 pos = pipeTrans.position;
            int posY = Random.Range(minHeight, maxHeight);
            while (posY == prevHeight)
            {
                posY = Random.Range(minHeight, maxHeight);
            }
            prevHeight = posY;
            clonePipe.transform.position = new Vector3(6, posY, pos.z);
            timer = 0;
        }
    }
}
