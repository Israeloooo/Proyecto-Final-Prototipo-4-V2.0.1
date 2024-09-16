
using System.Collections;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed;
    public float jumpSpeed;
    public bool CompareGround = false;
    public bool IsJumping = false;
    public float Vidas = 3;
    public GameObject bullet;
    //public Transform Gun;
    private SpriteRenderer spriteRenderer;
    public GameObject win;

    public GameManager gameManager;

    private bool isDead = false;
    private bool isWin = false;
    public TMP_Text lifesText;

    Vector2 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");



        if (Input.GetKeyDown(KeyCode.Space) && CompareGround == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed), ForceMode2D.Impulse);
            CompareGround = false;    
            IsJumping = true;
            
        }

        if (CompareGround == true)
        {
            x *= Speed;
            rb.velocity = new Vector2(x, rb.velocity.y);
            IsJumping = false;
        }
        
        if (IsJumping == true)
        {
            x *= Speed;
            rb.velocity = new Vector2(x, rb.velocity.y);
        }

        if (x == -1f)
        {
            spriteRenderer.flipX = true;

        }
        else if (x == 1f)
        {
            spriteRenderer.flipX = false;

        }
        else if (x == 1f)
        {
            spriteRenderer.flipX = false;
        }



        if (Vidas <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false);
            gameManager.gameOver();
            Debug.Log("GameOver");
        }

        //if (Input.GetKeyDown (KeyCode.Q))
        //Instantiate(bullet, Gun.position, Quaternion.identity);

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Piso"))
            CompareGround = true;

        if (collision.transform.CompareTag("Poison"))
        {
            Vidas -= 1;
            Die();
        }

       
        if (collision.transform.CompareTag("Win") && !isWin)
        {
            isWin = true;
            Time.timeScale = 0;
            gameManager.Win();
            Debug.Log("Win");
        }
    }


    void Die()
    {
        StartCoroutine(Respawn(0.3f));
    }

    IEnumerator Respawn(float duration)
    {
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
    }



}
