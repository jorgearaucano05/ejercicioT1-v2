using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = playerTransform.position.x;
        var y = transform.position.y;
        transform.position = new Vector3(x, y, transform.position.z);

    }
}
