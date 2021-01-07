using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMissiles : MonoBehaviour
{
    public GameObject missile;
    public GameObject bomb;
    Vector3 bombClone;
    Vector3 missileClone;
    Transform transform;

    float speed = 5f;
    int count = 0;
    bool whichWeapon = true;
    float timer = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(Input.GetKey(KeyCode.Space)){
            if (timer <= 0)
            {
                if (whichWeapon)
                {
                    missileClone = new Vector3(transform.position.x - 4.5f, 0, transform.position.z);
                    Instantiate(missile, missileClone, transform.rotation);
                        
                }
                else
                {
                    bombClone = new Vector3(transform.position.x + 4.58f, 0, transform.position.z);
                    Instantiate(bomb, bombClone, transform.rotation);
                    
                }
                whichWeapon = !whichWeapon;
                timer = 0.25f;
            }
              
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (timer <= 0)
            {
                missileClone = new Vector3(transform.position.x - 4.5f, 0, transform.position.z);
                Instantiate(missile, missileClone, transform.rotation);
                timer = 0.25f;
            }
        }
        if(Input.GetKey(KeyCode.D))
        {
            if (timer <= 0)
            {
                bombClone = new Vector3(transform.position.x + 4.58f, 0, transform.position.z);
                Instantiate(bomb, bombClone, transform.rotation);
                timer = 0.25f;
            }
        }
    } 
}
