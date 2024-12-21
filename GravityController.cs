using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public string name;
    private Vector3 gravity;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody is missing on the GameObject!");
            enabled = false;
        }
        else
        {
            // Disable default gravity if using custom gravity
            rb.useGravity = false;
        }
    }

    void FixedUpdate()
    {
        // Apply custom gravity to the Rigidbody
        if (rb != null)
        {
            gravity = getGravity();
            rb.AddForce(gravity, ForceMode.Acceleration);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 getGravity()
    {
        if (name == "Earth")
        {
            gravity = new Vector3(0, -9.81f, 0);
        }
        else if (name == "Moon")
        {
            gravity = new Vector3(0, -1.62f, 0);
        }
        else if (name == "Mars")
        {
            gravity = new Vector3(0, -3.71f, 0);
        }
        else if (name == "Jupiter")
        {
            gravity = new Vector3(0, -24.79f, 0);
        }
        else if (name == "Saturn")
        {
            gravity = new Vector3(0, -10.44f, 0);
        }
        else if (name == "Uranus")
        {
            gravity = new Vector3(0, -8.69f, 0);
        }
        else if (name == "Neptune")
        {
            gravity = new Vector3(0, -11.15f, 0);
        }
        else if (name == "Pluto")
        {
            gravity = new Vector3(0, -0.62f, 0);
        }
        else
        {
            gravity = new Vector3(0, -9.81f, 0);
        }
        return gravity;
    }
}
