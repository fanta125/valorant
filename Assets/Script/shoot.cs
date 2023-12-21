using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject obj;
    public float speed=10f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            bullet = Instantiate(obj,transform.position,transform.rotation);
            bullet.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }
}
