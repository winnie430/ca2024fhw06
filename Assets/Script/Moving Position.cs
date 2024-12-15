using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPosition : MonoBehaviour
{
    void Start()
    {
        // Move the object to the position between the two objects
        transform.position = (GameObject.Find("J_Bip_C_Neck_winnie").transform.position + GameObject.Find("J_Bip_C_Neck_nao").transform.position) / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object to the position between the two objects
        transform.position = (GameObject.Find("J_Bip_C_Neck_winnie").transform.position + GameObject.Find("J_Bip_C_Neck_nao").transform.position) / 2;
    }
}
