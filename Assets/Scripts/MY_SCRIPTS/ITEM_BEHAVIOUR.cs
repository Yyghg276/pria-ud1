using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITEM_BEHAVIOUR : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PLAYER")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("ITEM COLLECTED!");
        }
    }
}
