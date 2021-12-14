using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTable : MonoBehaviour
{
    // Start is called before the first frame update
    Transform tr;
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float rx = Input.GetAxis("Horizontal");
        tr.Rotate(new Vector3(1f, 0, 0), rx);
    }
}
