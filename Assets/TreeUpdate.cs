using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeUpdate : MonoBehaviour
{
    public Vector3 leftPoint;
    public Vector3 rightPoint;
    public GameObject apple;
    public float speed;
    public float spawnRate;

    private float timer;
    private bool goingLeft;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnRate;
    }

    // Update is called once per frame
    void FixedUpdate()
    {       
        Vector3 pos = transform.position;
        if (goingLeft) 
        {
            pos = Vector3.MoveTowards(pos, leftPoint, speed);
            if (Vector3.Distance(pos, leftPoint) <= 0.1) {goingLeft = false;}
        }
        else
        {
            pos = Vector3.MoveTowards(pos, rightPoint, speed);
            if (Vector3.Distance(pos, rightPoint) <= 0.1) {goingLeft = true;}
        }
        transform.position = pos;

        timer -= 1;
        if (timer <= 0)
        {
            Instantiate(apple, transform.position, Quaternion.identity);
            timer = spawnRate;
        }
    }
}
