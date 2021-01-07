using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpaceShip : MonoBehaviour
{

    float speed = 27f;
    float time = 1.0f;
    float missileTimer;
    float xRotation = 45f;
    Transform transform;
    Quaternion original;
    int count = 0;
    bool whichMissile = true;
    //public GameObject missile1;
    //public GameObject missile2;
    Vector3 clone;
    Quaternion target;
    
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        original = Quaternion.Euler(0,0,0);
        target = transform.rotation;
        missileTimer = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= -57.41){
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                target = Quaternion.AngleAxis(45, Vector3.forward); 
                transform.position += Vector3.left * Time.deltaTime * speed;
                
            }
        }
        if (transform.position.x <= 57.56){
            if (Input.GetKey(KeyCode.RightArrow))
            {
                target = Quaternion.AngleAxis(-45, Vector3.forward);
                transform.position += Vector3.right * Time.deltaTime * speed;
                
            }
        }
        if (Input.anyKey == false){
            if(original != target){
                target = original;
            }
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, target, 10 * time * Time.deltaTime);
    }

}
    
