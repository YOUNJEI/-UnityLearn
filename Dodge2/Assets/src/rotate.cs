using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotationspeed = 60f;

    private void Update()
    {
        transform.Rotate(0f, rotationspeed * Time.deltaTime, 0f);
    }
}
