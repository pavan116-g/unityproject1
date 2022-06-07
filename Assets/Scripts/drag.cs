using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

   

    private Rigidbody _rig;

    private void Start()
    {
        _rig = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        Vector3 prepos = transform.position;
        prepos.z = 0;
        transform.position = prepos;

    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag==this.gameObject.tag)
        {
            if(collision.rigidbody.velocity.magnitude<_rig.velocity.magnitude)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
