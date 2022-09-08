using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    [SerializeField] private Transform firepointTransform;
    [SerializeField] private Vector3 firePoint;
    [SerializeField] private Transform pfShell;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 moveDir = (mousePos - (Vector2)transform.position).normalized;
        float angle = Mathf.Atan2(moveDir.y, moveDir.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
        shoot();
    }
    private void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 moveDir = (mousePos - transform.position).normalized;
            firePoint = firepointTransform.position;
            ShootGun_Bullet.create(pfShell, firePoint, transform.position,3,0.4f);


        }
    }
}
