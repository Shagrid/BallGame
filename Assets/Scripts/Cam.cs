using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField] private Transform _target;

    // Start is called before the first frame update
    [SerializeField]private Vector3 offset = new Vector3(0, 2, 3);
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FollowToTarget();
    }
    
    public void FollowToTarget()
    {
        // gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, _target.position + offset, Time.deltaTime);
        // //gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, target.rotation, Time.deltaTime / TimeMoving);
        // gameObject.transform.LookAt(_target);
        transform.position= new Vector3(
            Mathf.Lerp(transform.position.x,_target.position.x, Time.deltaTime*2),
            Mathf.Lerp(transform.position.y,_target.position.y + 10,Time.deltaTime*2 ),
            Mathf.Lerp(transform.position.z,_target.position.z,Time.deltaTime*2 ));
    }
}
