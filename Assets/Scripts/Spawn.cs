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
        StartCoroutine(�reateTamplate());
        
    }

    private IEnumerator �reateTamplate()
    {
        int numberPoint;
        int CountSpawnPoints = _spawnPoints.Length;

        while (true)
        {
            numberPoint = Random.Range(0,CountSpawnPoints);
            �reateTamplate(_spawnPoints[numberPoint].transform.position);

            yield return new WaitForSeconds(2);
        }
    }
    public void �reateTamplate(Vector3 position)
    {
        GameObject newObject = Instantiate(Tamplate, position, Quaternion.identity);
    }
}
