using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Script : MonoBehaviour
{
    // Start is called before the first frame update
    private float z_trans;
    private float current_z_trans;
    private int HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = 20;
        current_z_trans = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        float pos_result;
        z_trans += 0.00005f;
        //pos_result = current_z_trans + z_trans * Time.deltaTime * 0.1f;
        transform.Translate(0.0f, 0.0f, z_trans);
        //Debug.Log(z_trans);
        if (transform.position.z <= -14.0f)
        {            // Kills the game object in 0 seconds 
            Destroy(gameObject, 0);
        }
    }

    public void Damage()
    {
        HP--;
        Debug.Log(HP);
        if (HP <= 0)
        {
            Destroy(gameObject, 0);
        }
    }
}
