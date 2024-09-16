using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject _Bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (transform.parent.GetComponent<SpriteRenderer>().flipX == false)
            {
                GameObject n = Instantiate(_Bullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                n.GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (transform.parent.GetComponent<SpriteRenderer>().flipX == true)
            {
                GameObject b = Instantiate(_Bullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                b.GetComponent<SpriteRenderer>().flipX = true;
            }

        }

        if (Input.GetKeyDown(KeyCode.A))
        { transform.localPosition = new Vector2(-0.75f, 0); }

        else if (Input.GetKeyDown(KeyCode.D))
        { transform.localPosition = new Vector2(0.75f, 0); }
    }

}