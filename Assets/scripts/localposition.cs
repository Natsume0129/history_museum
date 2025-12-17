using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localposition : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject a;
    public Vector3 localPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("x="+this.transform.localPosition.x);
        print("y="+this.transform.localPosition.y);
        print("z="+this.transform.localPosition.z);
    }
}
