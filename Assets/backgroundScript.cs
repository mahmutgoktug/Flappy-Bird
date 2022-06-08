using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour
{
    public GameObject pos;
    public float speed=3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);

    }

    private void FixedUpdate()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("detecter"))
        {
            Debug.Log("ANANINANASI");
            gameObject.transform.position = pos.transform.position;
        }
    }
}
