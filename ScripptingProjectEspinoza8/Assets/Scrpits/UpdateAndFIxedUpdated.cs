using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFIxedUpdated : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time:" + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time:" + Time.deltaTime); 
    }
}
