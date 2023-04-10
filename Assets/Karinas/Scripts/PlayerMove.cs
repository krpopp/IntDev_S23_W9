using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Movement Values")]
    [Range(0.1f, 2f)][SerializeField] private float speed = 0.53f;
    [SerializeField] private float sprint;
    [SerializeField] private float stealh;
    [SerializeField] private float swimming;

    [Header("World Collision")]
    [SerializeField]
    Collider2D worldCollider;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        if (Input.GetKeyDown(KeyCode.W))
        {
            newPos.y += speed;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            newPos.y -= speed;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            newPos.x -= speed;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            newPos.x += speed;
        }
        if (worldCollider.bounds.Contains(newPos))
        {
            transform.position = newPos;
        }
        
    }


}
