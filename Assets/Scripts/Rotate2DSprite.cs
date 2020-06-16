using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2DSprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log(Camera.main.transform.position);

        Vector3 targetVector = this.transform.position - Camera.main.transform.position;
        transform.rotation = Quaternion.LookRotation(targetVector);
    }
}
