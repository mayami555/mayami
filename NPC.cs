using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    public int health = 5;

    //������� NPC
    public int level = 1;

    //������� NPC
    public float speed = 1.2f;

    Vector3 newPosition;
            // Start is called before the first frame update
    void Start()
    {
        health =+level;
        print("�������� ���:" + health);
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z +=speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
