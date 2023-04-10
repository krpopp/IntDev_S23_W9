using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos_ShihaoKeyi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("playerx"))
        {
            float x = PlayerPrefs.GetFloat("playerx");
            float y = PlayerPrefs.GetFloat("playery");
            transform.position = new Vector3(x, y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetFloat("playerx", transform.position.x);
            PlayerPrefs.SetFloat("playery", transform.position.y);
            Debug.Log("saved position");
        }
    }
}
