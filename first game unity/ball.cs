using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ball : MonoBehaviour
{
    Vector3 newSize = new Vector3(20.5f, 20.5f, 20.5f);
  
    public GameObject Gate;
    public Rigidbody rb;
    public float force = 500;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector3.up * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "redstone")
        {
            int currentLevel = SceneManager.GetActiveScene().buildIndex;
            currentLevel += 1;
        }
      else if(collision.gameObject.tag == "SizeBlock")
        {
            transform.localScale = newSize;
        }
        else if (collision.gameObject.tag == "Teleport")
        {
            transform.position = Gate.transform.position;
        }
       
    }
}
