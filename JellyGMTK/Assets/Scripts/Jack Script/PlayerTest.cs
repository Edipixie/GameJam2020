using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    string PlayerDir = "north";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveFunction();
    }

    public void PlayerMoveFunction()
    {
        if (PlayerDir == "north")
        {
            if (Input.GetKeyDown("w"))
            {
                this.transform.position += new Vector3(0f, 0f, 0.5f);
            }
            else if (Input.GetKeyDown("d"))
            {
                this.transform.position += new Vector3(0.5f, 0f, 0f);
            }
            else if (Input.GetKeyDown("a"))
            {
                this.transform.position += new Vector3(-0.5f, 0f, 0f);
            }
            else if (Input.GetKeyDown("s"))
            {
                this.transform.position += new Vector3(0f, 0f, -0.5f);
            }
            else if (Input.GetKeyDown("q"))
            {
                this.transform.rotation = Quaternion.Euler(0f, -90f, 0f);

            }
            else if (Input.GetKeyDown("e"))
            {
                this.transform.rotation = Quaternion.Euler(0f, -90f, 0f);

            }
        }
    }
}