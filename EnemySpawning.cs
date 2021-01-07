using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    float speed = 20f;
    Transform transform;
    public GameObject enemy;
    
    float time = 4.0f;
    Vector3 clone;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            clone = new Vector3(Random.Range(-54, 54),0, transform.position.z);
            Instantiate(enemy, clone, transform.rotation);
            time = 4.0f;
        }
    }

}
