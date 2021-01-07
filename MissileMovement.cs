using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour
{
    float speed = 20f;
    Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += Vector3.forward * Time.deltaTime * speed;
       if(transform.position.z >= 33){
           Destroy(transform.gameObject);
       } 
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

    }
}
