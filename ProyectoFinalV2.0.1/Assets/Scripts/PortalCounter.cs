using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PortalCounter : MonoBehaviour
{
    public static  PortalCounter Instance;

    public TMP_Text portalText;
    public int currentPortal = 0;
    public bool PortalActivation = false;
    
    // Start is called before the first frame update

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        portalText.text = "Fragmentos de Portal: " + currentPortal.ToString();
    }

    // Update is called once per frame
    public void IncreasePortal(int v)
    {
        currentPortal += v;
        portalText.text = "Fragmentos de Portal: " + currentPortal.ToString(); 
    }

    void Update()
    {
        if (currentPortal == 5)
        {
            transform.position = new Vector3(16.18f, 0.8f);
        }
    }
}
