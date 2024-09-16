
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
    public class BulleScript : MonoBehaviour
    {
        //private Rigidbody2D rb;
        //[SerializeField]
        //private bool _Face = true;

        //// Start is called before the first frame update
        //void Start()
        //{
        //    rb = GetComponent<Rigidbody2D>();

        //}

        //void Update()
        //{
        //    if (GetComponent<SpriteRenderer>().flipX == false)
        //    {
        //        rb.velocity = new Vector2(3, 0);

        //    }
        //    else if (GetComponent<SpriteRenderer>().flipX == true)
        //    {
        //        rb.velocity = new Vector2(-3, 0);

        //    }
        //    Destroy(this.gameObject, 1.5f);

        //}
        //private void OnCollisionEnter2D(Collision2D collision)
        //{
        //    if (collision.transform.tag != "Player")
        //        Destroy(this.gameObject);
        //}
    }
