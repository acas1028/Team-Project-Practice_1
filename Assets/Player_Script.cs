using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    private float x_pos = 0.0f;
    private float y_pos = 0.0f;
    private float moving_speed = 10.0f;
    private float rot_speed = 50.0f;

    private int a;
    private int counter;

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Player_Moving_Control();
        //Rotation();
        Shoot();
    }

    private void Player_Moving_Control()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * this.moving_speed * Time.smoothDeltaTime * keyHorizontal, Space.World);
        transform.Translate(Vector3.up * this.moving_speed * Time.smoothDeltaTime * keyVertical, Space.World);
    }

    private void Rotation()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * this.rot_speed * Time.deltaTime;
        v = v * this.rot_speed * Time.deltaTime;

        transform.Rotate(Vector3.back * h);
        transform.Rotate(Vector3.right * v);
    }

    private void Shoot()
    {
        Quaternion rotation = Quaternion.identity;

        rotation.eulerAngles = new Vector3(-90, 0, 0);
        if(Input.GetKey(KeyCode.Space))
        {
            ++a;
            counter = a % 15;
            if (counter == 1)
            {
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), rotation);
            }
        }
    }
}
