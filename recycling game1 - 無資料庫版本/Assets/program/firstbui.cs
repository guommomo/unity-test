using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LukeWaffel.BUI;

public class firstbui : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void apple()
    {
        UIBox firstbox = new UIBox("firstBox", BUI.UIType.Message);
        firstbox.header = "My First Title !";
        firstbox.body = "Hi";

        BUI.Instance.AddToQueue(firstbox);
    }
}
