using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public int selectedWeapon=0;
    private Inventory inventory;
    private PickUp Pickup;
    static public GameObject[] guns;
    // Start is called before the first frame update
    void Start()
    {

        SelectedWeapon();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();


    }
    // Update is called once per frame
    void Update()
    {
        int previousWeapon = selectedWeapon;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedWeapon = 2;
        }
        if (previousWeapon != selectedWeapon)
        {
            SelectedWeapon();
        }
    }
    private void SelectedWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedWeapon )
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
