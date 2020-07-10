using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
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
        } else if (Input.GetKeyDown("q"))
        {
            //this.transform.rotation += new Vector3(0f, 0f, 0f);

        }
}