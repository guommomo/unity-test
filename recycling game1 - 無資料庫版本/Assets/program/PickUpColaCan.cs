using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpColaCan : MonoBehaviour
{
    public Image myImage;
    public firstbui work1;
    public GameObject ColaCanOnPlayer;
    // Start is called before the first frame update
    void Start()
    {
        work1 = GameObject.FindGameObjectWithTag("work1").GetComponent<firstbui>();

        ColaCanOnPlayer.SetActive(false);
        
    }

    // Update is called once per frame

    void OnMouseDown()
    {


        work1.apple();
        gameObject.SetActive(false); //會讓原本的垃圾不見
        ColaCanOnPlayer.SetActive(true);
    }

}
