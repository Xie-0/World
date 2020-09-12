using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 0.2f;
    int way;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creeper!Ohhhh Man!");
    }

    // Update is called once per frame
    void Update()
    {
        way = Random.Range(0,3);
        if (way == 0)
        {
            for(int num = 0; num < 10; num++)
            {
                this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
            }
        }
        else if (way == 1)
        {
            this.transform.Rotate(Vector3.down * Random.Range(30,91));
            for (int num = 0; num < 10; num++)
            {
                this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
            }
        }
        else if (way == 2)
        {
            this.transform.Rotate(Vector3.up * Random.Range(30, 91));
            for (int num = 0; num < 10; num++)
            {
                this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
            }
        }

        if(this.transform.position.y > 20)
        {
            this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
        }
    }
}
