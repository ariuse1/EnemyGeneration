using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Jellyfish _tamplate;   
    
    private SpawnPoint[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = gameObject.GetComponentsInChildren<SpawnPoint>();
        StartCoroutine(CreateTamplate());        
    }

    private IEnumerator CreateTamplate()
    {
        int numberPoint;
        int countSpawnPoints = _spawnPoints.Length;
        int seconds = 2;
        WaitForSeconds waitForSeconds = new WaitForSeconds(seconds);

        while (true)
        {
            numberPoint = Random.Range(0,countSpawnPoints);
            CreateTamplate(_spawnPoints[numberPoint].transform.position);

            yield return waitForSeconds;
        }
    }

    public void CreateTamplate(Vector3 position)
    {        
        GameObject newObject = Instantiate(_tamplate.gameObject, position, Quaternion.identity);
    }
}
