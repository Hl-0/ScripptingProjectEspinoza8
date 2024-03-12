using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

public class AxisRawExample : MonoBehaviour
{
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Horizontal");
        float yPos = v * range;

        transform.position = new Vector3 (yPos, 2f, 0);
        Debug.Log("Value Returned: " + v.ToString("F2"));
    }
}
