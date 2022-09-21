using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;
    public float speed1 = 8f;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            playerRigidbody.AddForce(0f, -speed1, 0f);
        }

        Vector3 newVelocity = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Jump") * speed, Input.GetAxis("Vertical") * speed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
