using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    private Function function;
    private float fallingSpeed = 3;
    void Start()
    {
        function = GameObject.FindGameObjectWithTag("GameController").GetComponent<Function>();
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.down * fallingSpeed) * Time.deltaTime;
        if (transform.position.y < -8)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Player")
        {
            function.gameOver();
            Destroy(collision);
            Destroy(gameObject);
        }
    }
}
