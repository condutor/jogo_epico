using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class ShootGun_Bullet : MonoBehaviour
{
    private int spread;
    // Start is called before the first frame update
    public static void create(Transform pfShell, Vector3 spawnPos, Vector3 targetPos,int amountofBullets,float bulletSpread)
    {
        for (int i=0; i < amountofBullets; i++) {
            ShootGun_Bullet shootGun_Bullet = Instantiate(pfShell, spawnPos, Quaternion.identity).GetComponent<ShootGun_Bullet>();
            shootGun_Bullet.Setup(targetPos,amountofBullets,bulletSpread);
        }
    }

    public void Setup(Vector3 targetPos,int amountofBullets,float bulletSpread)
    {
        Vector3 moveDir = (targetPos - transform.position).normalized;
        Vector3 pDir = Vector2.Perpendicular((Vector2)moveDir)*Random.Range(-bulletSpread,bulletSpread);
        float moveSpeed = 20f;
        gameObject.GetComponent<Rigidbody2D>().velocity = (-moveDir - pDir) * moveSpeed;
        transform.localEulerAngles = new Vector3(0, 0, UtilsClass.GetAngleFromVector(moveDir));
        Destroy(gameObject, 0.5f);


    }
}
