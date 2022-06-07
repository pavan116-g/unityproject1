using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSphere : MonoBehaviour
{
    private float _speed = 5.0f;

    [SerializeField]
    private GameObject _spherefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hInupt2 = Input.GetAxis("Horizontal2nd");
        float vInput2 = Input.GetAxis("Vertical2nd");

        transform.Translate(new Vector3(hInupt2, vInput2, 0) * Time.deltaTime * _speed);

        if (transform.position.y >= 8.26)
        {
            transform.position = new Vector3(transform.position.x, -3.4f, 0);
        }
        else if (transform.position.y <= -3.4)
        {
            transform.position = new Vector3(transform.position.x, 8.25f, 0);
        }
        if (transform.position.x < -3.45)
        {
            transform.position = new Vector3(7.26f, transform.position.y, 0);
        }
        else if (transform.position.x > 9.35f)
        {
            transform.position = new Vector3(-3.45f, transform.position.y, 0);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere")
        {
            Destroy(other.gameObject);
        }
    }

}

