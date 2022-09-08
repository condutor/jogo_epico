using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class Grenade : MonoBehaviour
{
    
    
    private Collision2D collision;
    public static void create(Transform pfGrenade, Vector3 spawnPos, Vector3 targetPos)
    {
        Grenade grenade = Instantiate(pfGrenade, spawnPos, Quaternion.identity).GetComponent<Grenade>();

        grenade.Setup(targetPos);
    }
 
    public void Setup(Vector3 targetPos)
    {
        Vector3 moveDir = (targetPos - transform.position).normalized;
        float moveSpeed = 20f;
        gameObject.GetComponent<Rigidbody2D>().velocity = -moveDir * moveSpeed;
        Debug.Log(moveDir);
        transform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVector(moveDir));
        Destroy(gameObject, 2.5f);


    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}