using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject player = null;
    [SerializeField]
    private Transform spawnPoint = null;
    [SerializeField]
    private Rigidbody playerRB = null;
    [SerializeField]
    private float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(player);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerRB.AddForce(new Vector3(-speed, 0, 0));
            Debug.Log("Yes");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRB.AddForce(new Vector3(speed, 0, 0));
            Debug.Log("YEs");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, speed));
            Debug.Log("YEs");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, -speed));
            Debug.Log("YEs");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(new Vector3(0, speed, 0));
            Debug.Log("YEs");
        }
    }
}
