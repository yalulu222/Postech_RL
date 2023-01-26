using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3[] positionArray;
    public GameObject Spheres;

    Vector3 momentum = new Vector3(0,0,0);
    void Start()
    {
        positionArray = Spheres.GetComponent<create_sphere>().positionArray;
    }

    // Update is called once per frame
    void Update()
    {
        calulate_gravity();
    }
    void calulate_gravity(){
        
    }
}
