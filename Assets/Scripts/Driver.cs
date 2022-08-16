using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 365f;
    [SerializeField] float moveSpeed = 25f;
    [SerializeField] float slowSpeed = 18f;
    [SerializeField] float boostSpeed = 35f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed * Time.deltaTime;
        float moveDir = Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0, moveDir, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boostSpeed")
        {
            moveSpeed = boostSpeed;
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }
}
