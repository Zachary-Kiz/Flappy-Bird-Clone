using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCycler : MonoBehaviour
{
    public Sprite[] sprites;
    public float framerate = 0.1f;

    private SpriteRenderer spriteRenderer;
    private int currentIndex = 0;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (sprites.Length > 0)
        {
            spriteRenderer.sprite = sprites[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVars.gameOver) return;

        timer += Time.deltaTime;
        if (timer >= framerate)
        {
            currentIndex = ( currentIndex + 1 ) % sprites.Length;
            spriteRenderer.sprite = sprites[currentIndex];
            timer = 0f;
        }
    }
}
