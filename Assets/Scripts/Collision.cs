using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] Color32 hasPackageColor = new Color32 (11, 239, 15, 239);
    [SerializeField] Color32 noPackageColor = new Color32 (255, 255, 255, 255);
    [SerializeField] float destroyDelay = 0.1f;
    SpriteRenderer cruisyRenderer;


    void Start()
    {
        cruisyRenderer = GetComponent<SpriteRenderer>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            if(hasPackage)
            Destroy(other.gameObject, destroyDelay);
            cruisyRenderer.color = hasPackageColor;
           
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("package delivered");
            hasPackage = false;
            cruisyRenderer.color = noPackageColor;
        }
    }
}
