using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
