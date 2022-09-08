using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour
{
   
    public Transform pfGrenade;

    public Transform firePointTransform;

    public Vector3 firePoint;
    // Start is called before the first frame update
    void Awake()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 Direction = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);

        


    }

    private void Shoot()
    {

        if (Input.GetMouseButtonDown(0))
        {
            firePoint = firePointTransform.position;
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 Direction = (mousePos - transform.position).normalized;
            Grenade.create(pfGrenade,firePoint,transform.position);
           


        }
    }
}
