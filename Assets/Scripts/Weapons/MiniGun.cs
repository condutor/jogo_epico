using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGun : MonoBehaviour
{
    private Vector3 firePoint;
    public Transform firepointTransform;
    public event EventHandler <OnShootArgs> OnShoot;
    public class OnShootArgs
    {
        public Vector3 firePoint;
        public Vector2 mousePos;
        public Vector2 moveDir;
        public Vector3 targetPos;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 moveDir = (mousePos - (Vector2)transform.position).normalized;
        float angle = Mathf.Atan2(moveDir.y, moveDir.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
    private void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 moveDir = (mousePos - (Vector2)transform.position).normalized;
            firePoint = firepointTransform.position;
            OnShoot?.Invoke(this, new OnShootArgs { firePoint = firePoint,mousePos = mousePos, moveDir = moveDir ,targetPos = transform.position});
        }
    }
}
