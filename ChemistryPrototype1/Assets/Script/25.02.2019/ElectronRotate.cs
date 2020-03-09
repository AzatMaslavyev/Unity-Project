using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronRotate : MonoBehaviour
{
    public GameObject atomcore = null;
    Vector3 pointatomcore = Vector3.zero;
    float numberY = 1f;
    float numberZ = 1f;
    float speed = 230f;
    float time = 0f;
    float startspeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        startspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 point = new Vector3(0f, numberY, numberZ);
        transform.LookAt(atomcore.transform.position);
        Vector3 pointatomcore = new Vector3(atomcore.transform.position.x, atomcore.transform.position.y, atomcore.transform.position.z);
            if (time <= 1.0f)
            {
                //Debug.Log("IF");
                //Debug.Log(point);
                transform.RotateAround(pointatomcore, point, speed * Time.deltaTime);
                time += Time.deltaTime;
            }

            if(time >= 1.0f)
            {
                speed = Mathf.Lerp(230, 0, Time.deltaTime);
                numberZ = Random.Range(-1f, 1f);
                numberY = Mathf.Round(Random.Range(-1f, 1f));
                    if (numberY == 0)
                    {
                        numberY = 1f;
                    }
                //Debug.Log("Time = " + time);
                time = 0f;
            }
        speed = startspeed;
        
    }
}
