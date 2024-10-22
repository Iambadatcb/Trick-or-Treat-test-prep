using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public Transform candy;
    public float speed = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true)
        {

            candy.transform.position += new Vector3(candy.position.x,-1,0)* (Time.deltaTime * speed);
        }
        if (gameObject.activeSelf == false)
        {
            gameObject.SetActive(true);
            candy.transform.position += new Vector3(Random.Range(-8, 8), 4, 0);

        }
    }
}
