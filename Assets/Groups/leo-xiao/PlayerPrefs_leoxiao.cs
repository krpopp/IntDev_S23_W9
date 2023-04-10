using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs_leoxiao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("playerX"))
        {
            float x = PlayerPrefs.GetFloat("playerX");
            float y = PlayerPrefs.GetFloat("playerY");
            transform.position = new Vector3(x, y, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetFloat("playerX", transform.position.x);
            PlayerPrefs.SetFloat("playerY", transform.position.y);
            Debug.Log("saved position");
        }
    }
}
