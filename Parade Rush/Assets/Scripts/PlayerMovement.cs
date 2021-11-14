using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D playerbody;
    public float speed;
    public float jumpspeed;
    private bool isgrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        playerbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, playerbody.velocity.y);

        if (Input.GetKey(KeyCode.Space) && isgrounded == true)
        {
            playerbody.velocity = new Vector2(playerbody.velocity.x, jumpspeed);
            isgrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isgrounded = true;
        }
    }


}
