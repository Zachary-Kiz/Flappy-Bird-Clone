using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    private Rigidbody2D rb;
    public AudioSource audioSource;
    public AudioSource deathAudio;
    public float jumpForce = 10f;
    private float minRotationZ = -90f;
    private float maxRotationZ = 30f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVars.gameOver) return;

        if (rb.velocity.y < 0) // Falling
        {
            rb.AddTorque(-100f); // Negative = forward flip
        } else if (rb.velocity.y > 0)
        {
            rb.SetRotation(maxRotationZ);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!GlobalVars.hasStarted)
            {
                GlobalVars.hasStarted = true;
                rb.gravityScale = 3.5f;
            }
            audioSource.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GlobalVars.gameOver = true;
        deathAudio.Play();
    }

    void FixedUpdate()
    {
        float zRotation = rb.rotation; // in degrees

        // Clamp between 0 and maxRotationZ (assuming 0 is upright)
        float clampedZ = Mathf.Clamp(zRotation, minRotationZ, maxRotationZ);
        rb.MoveRotation(clampedZ);
    }
}
