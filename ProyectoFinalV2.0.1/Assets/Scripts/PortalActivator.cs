using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActivator : MonoBehaviour
{

    public PortalCounter PortalCounter;
    public bool Portal = false;
    public CircleCollider2D PortalObject;
    public SpriteRenderer PortalRer;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void ActivarPortal()
    {
        if (PortalCounter.PortalActivation == true)
        {
            transform.position = new Vector2(16f, 0.78f);
        }
    }
}
