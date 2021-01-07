using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float speed = 15f;
    Transform transform;
    public GameObject explosion;
    bool onRight = true;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > 15)
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }

        else if (transform.position.x < -5)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        else if (transform.position.x > 5)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        else
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }

        if (transform.position.z < -42)
        {
            Destroy(transform.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(transform.gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
