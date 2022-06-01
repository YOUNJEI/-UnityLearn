using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Rigidbody abcRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        abcRigidbody.AddForce(0, 500, 0);
    }
}
