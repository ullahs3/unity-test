using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_controller : MonoBehaviour
{
    //Declaration
    [SerializeField] public float moveSpeed = 10f;
    SpriteRenderer render;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-21, 0, 0);
        render = gameObject.GetComponent<SpriteRenderer>(); // assign sprite renderer
        //render.color = new Color(0.0f, 0.0f, 0.0f, 1f);
 

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        //transform.position += moving * Time.deltaTime * moveSpeed;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            move += Vector3.up;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move += Vector3.down;
        }

        transform.position += move * moveSpeed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
        }

    }
}
