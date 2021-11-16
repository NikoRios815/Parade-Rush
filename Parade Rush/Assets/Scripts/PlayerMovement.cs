using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D playerbody;
    public float speed;
    public float jumpspeed;
    private bool isgrounded;
    public GameObject player;
    public Camera cam;
    private Animator anim;
    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        playerbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        playerbody.velocity = new Vector2(horizontalInput * speed, playerbody.velocity.y);
        cam.transform.position = new Vector3(transform.localPosition.x + 3f, transform.localPosition.y + 2f, transform.localPosition.z - 10f);
        
        //flips the player image
        if(horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(4.9994f, 4.9994f, 4.9994f);
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-4.9994f, 4.9994f, 4.9994f);
        }

       //Checks when player leaves the groud after jump 
        if (Input.GetKey(KeyCode.Space) && isgrounded == true)
        {
            Jump();
            isgrounded = false;
        }

        //Set animation parameters
        anim.SetBool("run", horizontalInput != 0);
        anim.SetTrigger("jump");
        anim.SetBool("grounded", grounded);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isgrounded = true;
            grounded = true;
        }
    }

    private void Jump()
    {
        playerbody.velocity = new Vector2(playerbody.velocity.x, jumpspeed);
        grounded = false;
    }

}
