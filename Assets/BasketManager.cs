using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketManager : MonoBehaviour
{
    public float speed;
    public GameObject basket;
    public GameObject gameover;

    private int baskets;

    void Start()
    {   
        for (int i = 3; i >= 1; --i)
        {   
            Vector3 pos = transform.position;
            pos.y += (1.2f * (i - 1)) - 0.4f;
            Instantiate(basket, pos, Quaternion.identity);
        }
        baskets = 3;
    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        /*if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }*/

        pos.x = (20 / (Screen.width / Input.mousePosition.x)) - 10;
        //Debug.Log(pos.x);
        transform.position = pos;
    }

    void LoseBasket()
    {   
        GameObject basket = GameObject.Find("Basket(Clone)");
        Destroy(basket);
        baskets -= 1;
        if (baskets <= 0){
            gameover.GetComponent<TextMeshProUGUI>().text = "Game Over";
        }
    }
}
