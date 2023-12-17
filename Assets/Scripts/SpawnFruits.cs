using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits1 : MonoBehaviour
{
    public List<GameObject> Fruits;
    float time = 0;
    void Start()
    {
    }
    void Update()
    {
        int randomIndex = Random.Range(0, Fruits.Count);
        GameObject f = Fruits[randomIndex];
        if (time < 2f)
        {
            time = time + Time.deltaTime;
        }else
        {
            dropRandomFruit(f);
            time = 0;
        }
    }
    public void dropRandomFruit(GameObject f){
        Instantiate(f, new Vector3(Random.Range(-8, 8), 8), transform.rotation);
    }
}
