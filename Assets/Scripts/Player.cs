using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            
            player.transform.position += new Vector3(-1,0,0)* (Time.deltaTime * speed);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            player.transform.position += new Vector3(1, 0, 0) * (Time.deltaTime * speed);

            
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            player.transform.position += new Vector3(-1, 0, 0) * (Time.deltaTime * speed);
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            player.transform.position += new Vector3(1, 0, 0) * (Time.deltaTime * speed);

        }
    }
}
