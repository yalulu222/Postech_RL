using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_sphere : MonoBehaviour
{
    public GameObject Sphere;
    public Vector3[] positionArray;
    // Start is called before the first frame update
    void Start()
    {
        positionArray = new Vector3[5];
        for (int i = 0; i < 5; i++)
        {
            positionArray[i] = new Vector3(Random.Range(-14, 14),Random.Range(1, 29),Random.Range(-14, 14));
            GameObject newShere = Instantiate(Sphere);
            newShere.transform.position = positionArray[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
