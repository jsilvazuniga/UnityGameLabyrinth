using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f, rot = 80f, curSpeed;
  //  private Vector3 deplacement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            deplacement = Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            deplacement = Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // deplacement = Vector3.left;
            deplacement = Vector3.zero;
            transform.Rotate(Vector3.up * -30 * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //   deplacement = Vector3.right;
            deplacement = Vector3.zero;
            transform.Rotate(Vector3.up * 30 * Time.fixedDeltaTime);
        }
        */

        //vitesse
        if (Input.GetKey(KeyCode.LeftControl)){
            curSpeed = speed * 2;
        }
        else
        {
            curSpeed = speed;
        }

        /*
        transform.Translate(deplacement * curSpeed * Time.fixedDeltaTime);
        deplacement = Vector3.zero;*/

        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));

        transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));

    }
}
