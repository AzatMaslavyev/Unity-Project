using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse : MonoBehaviour
{
    
    public GameObject[] objects;
    public Transform SpawnZone;


    float maxX;
    float minX;
    float maxZ;
    float minZ;
    float maxY;
    float minY;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        maxX = SpawnZone.position.x + SpawnZone.localScale.x / 2.0f;
        minX = SpawnZone.position.x - SpawnZone.localScale.x / 2.5f;

        maxZ = SpawnZone.position.z + SpawnZone.localScale.z / 2.0f;
        minZ = SpawnZone.position.z - SpawnZone.localScale.z / 2.5f;

        maxY = SpawnZone.position.y + SpawnZone.localScale.y / 2.0f;
        minY = SpawnZone.position.y - SpawnZone.localScale.y / 2.5f;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Mouse0))
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(maxY,minY), Random.Range(minZ, maxZ));
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.CompareTag("Btn_Plus_Neutron"))
                {
                    Debug.Log("Btn_Plus_Neutron");
                    Instantiate(objects[0], spawnPos, Quaternion.identity);
                }
                if (selection.CompareTag("Btn_Minus_Neutron"))
                {
                    Debug.Log("Btn_Minus_Neutron");
                    Destroy(GameObject.FindWithTag("Neutron"));
                }
                if (selection.CompareTag("Btn_Plus_Proton"))
                {
                    Instantiate(objects[1], spawnPos, Quaternion.identity);
                    Debug.Log("Btn_Plus_Proton");
                }
                if (selection.CompareTag("Btn_Minus_Proton"))
                {
                    Debug.Log("Btn_Minus_Proton");
                    Destroy(GameObject.FindWithTag("Proton"));
                }
                if (selection.CompareTag("Btn_Plus_Electron"))
                {
                    i++;
                    if(i==3){
                        i = 0;
                    }
                        if (i == 0)
                        {
                            Instantiate(objects[2], spawnPos, Quaternion.identity);
                            Debug.Log("Btn_Plus_Electron");
                            Debug.Log(i);
                        }
                        if (i == 1)
                        {
                            Instantiate(objects[3], spawnPos, Quaternion.identity);
                            Debug.Log("Btn_Plus_Electron");
                            Debug.Log(i);
                        }
                        if (i == 2)
                        {
                            Instantiate(objects[4], spawnPos, Quaternion.identity);
                            Debug.Log("Btn_Plus_Electron");
                            Debug.Log(i);
                        }
                    
                }
                if (selection.CompareTag("Btn_Minus_Electron"))
                {
                    Debug.Log("Btn_Minus_Electron");
                    Destroy(GameObject.FindWithTag("Electron"));
                }

            }
            }
        }
    }
