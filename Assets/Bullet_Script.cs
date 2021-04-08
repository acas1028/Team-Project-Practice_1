using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    private float z_pos;
    // Start is called before the first frame update
    void Start()
    {
        z_pos = 0.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        z_pos += 0.2f;
        transform.Translate(0.0f, -z_pos * Time.deltaTime , 0.0f);

        if(z_pos > 80.0f)
        {
            Destroy(gameObject, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy_Tag")
        {
            Destroy(gameObject, 0);
            Destroy(other.gameObject, 0);
        }
        if(other.gameObject.tag == "Boss_Tag")
        {
            Destroy(gameObject, 0);
            other.GetComponent<Boss_Script>().Damage();
        }
    }
}
