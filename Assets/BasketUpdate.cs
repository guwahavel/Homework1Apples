using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketUpdate : MonoBehaviour
{   
    private GameObject manager;

    // Start function passed from BasketManager
    void Start()
    {
        manager = GameObject.Find("BasketManager");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = manager.transform.position.x;
        transform.position = pos;
    }

    void OnTriggerStay2D(Collider2D other)
    {   
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Apple(Clone)"){Destroy(other.gameObject);}
    }
}
