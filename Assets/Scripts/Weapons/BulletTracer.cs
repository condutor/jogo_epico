using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class BulletTracer : MonoBehaviour
{
    [SerializeField]
    private MiniGun miniGun;
    [SerializeField]
    private Material weaponTracerMaterial;

    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        miniGun.OnShoot += Bullet_Tracer;
        miniGun.OnShoot += Bullet;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Bullet_Tracer(object sender, MiniGun.OnShootArgs e)
    {

    }
    private void Bullet(object sender, MiniGun.OnShootArgs e)
    {
        RaycastHit2D raycastHit2D = Physics2D.Raycast(e.firePoint, e.moveDir);

        if (raycastHit2D.collider != null)
        {
            Debug.Log("Hit");
            if(raycastHit2D.collider.transform.gameObject.name == "Enemy")
            {
                raycastHit2D.collider.GetComponent<EnemyHealth>().health -= damage;

            }
        }
    }
}