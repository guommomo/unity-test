using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5.0f; // 移動速度

    

    // Start is called before the first frame update

    void Start()

    {

    }

    // Update is called once per frame

    void Update()

    {
        //角色移動
        if (Input.GetKey("up")) { transform.Translate(0, 0, moveSpeed * Time.deltaTime); }

        if (Input.GetKey("down")) { transform.Translate(0, 0, -moveSpeed * Time.deltaTime); }

        if (Input.GetKey("left")) { transform.Translate(-moveSpeed * Time.deltaTime, 0, 0); }

        if (Input.GetKey("right")) { transform.Translate(moveSpeed * Time.deltaTime, 0, 0); }

        if (Input.GetKey(KeyCode.Space)) { transform.Translate(0, moveSpeed * Time.deltaTime, 0); }

        
       
        

    }
}
