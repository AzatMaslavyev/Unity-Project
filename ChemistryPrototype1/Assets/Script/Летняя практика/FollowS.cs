using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowS : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("FollowS").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
