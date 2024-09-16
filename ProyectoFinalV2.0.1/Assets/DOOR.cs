using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOOR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        transform.position = new Vector2(37f, 10.71f);
    }
}
