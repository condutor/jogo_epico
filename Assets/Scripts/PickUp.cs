using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject button;
    public Transform weaponReference;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(other.tag);
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false )
                {
                    weaponReference.parent = GameObject.FindGameObjectWithTag("Player").transform;
                    weaponReference.position = GameObject.FindGameObjectWithTag("Player").transform.position;
                    inventory.isFull[i] = true;
                    Instantiate(button, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                    //add stuff
                }
            }
        }
    }
}
