using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private Grenade grenade;
    // Start is called before the first frame update

    public void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        Transform atacker = collision.gameObject.transform;
        Vector3 moveDir = (transform.position - atacker.position).normalized;
        Debug.Log(moveDir);
    }
}
