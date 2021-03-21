using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    public float minTime = 1f;
    public float maxTime = 2f;

    // Creamos una corrutina
    IEnumerator SpawnCoroutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)], transform.position, Quaternion.identity);

        // Para que vuelva a ejecutarse la corrutina con un tiempo aleatorio.
        StartCoroutine(SpawnCoroutine(Random.Range(minTime, maxTime)));
    }


    // Start is called before the first frame update
    void Start()
    {
        // Inicio de la corrutina
        StartCoroutine(SpawnCoroutine(0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
