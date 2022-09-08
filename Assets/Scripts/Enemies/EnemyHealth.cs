using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public bool wasHit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health < 1)
        {
            Destroy(gameObject);
        }
    }
    private void Damage()
    {
        if (wasHit == true)
            health -= GetComponent<BulletTracer>().damage;
            wasHit = false;
    }
}
