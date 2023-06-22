using System.Collections;

using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Tamplate; 

   
    private SpawnPoint[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = gameObject.GetComponentsInChildren<SpawnPoint>();
        StartCoroutine(ÑreateTamplate());
        
    }

    private IEnumerator ÑreateTamplate()
    {
        int numberPoint;
        int CountSpawnPoints = _spawnPoints.Length;

        while (true)
        {
            numberPoint = Random.Range(0,CountSpawnPoints);
            ÑreateTamplate(_spawnPoints[numberPoint].transform.position);

            yield return new WaitForSeconds(2);
        }
    }
    public void ÑreateTamplate(Vector3 position)
    {
        GameObject newObject = Instantiate(Tamplate, position, Quaternion.identity);
    }
}
