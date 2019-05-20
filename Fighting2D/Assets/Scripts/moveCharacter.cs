using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveCharacter : MonoBehaviour
{
	private float speed = GlobalBalance.speed; public Text Speed;
	private float jumpForce = GlobalBalance.jumpForce;  public Text JumpForce;
    private float moveInput; 
    private Rigidbody2D rb;

    public GameObject player;
    private bool facingRight = false;
    public Transform kick;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpValue;

    // Use this for initialization
    void Start()
    {
        extraJumps = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();

		Speed.text = "Speed: " + speed.ToString ();
		JumpForce.text = "Jump force: " + jumpForce.ToString ();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight && moveInput > 0)
        {
            flip();
        } else if (!facingRight && moveInput < 0)
        {
            flip();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            player.GetComponent<Animator>().SetTrigger("Attack");
        }
    }

    private void Update()
    {
        if (isGrounded)
        {
            extraJumps = extraJumpValue;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        } else if(Input.GetKeyDown(KeyCode.Space) && extraJumps > 0 && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void strike()
    {
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;
        Instantiate(kick, new Vector3(posX, posY, 0), this.transform.rotation);
    }
}
