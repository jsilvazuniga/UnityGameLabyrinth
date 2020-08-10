using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomScript : MonoBehaviour
{
    [SerializeField]
    float speed = 4f;

    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);

        if (collision.collider.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
        }
    }
}
