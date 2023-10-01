using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlock : MonoBehaviour
{
    public float rotateSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = Vector3.one;
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right*rotateSpeed);
    }
}
