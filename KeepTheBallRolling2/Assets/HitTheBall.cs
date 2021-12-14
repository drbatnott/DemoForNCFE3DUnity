using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTheBall : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Vertical");
        Vector3 forceDirection = new Vector3(0, 0, 1f);
        rb.AddForce(h * forceDirection, ForceMode.Impulse);
    }
}
