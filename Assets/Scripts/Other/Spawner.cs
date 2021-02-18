using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _money;
    [SerializeField] private Transform _spawnPoint;

    private WaitForSeconds _waitForSeconds = new WaitForSeconds(5f);
    private float _randomX;
    private float _randomY;
    private int _maximumSpawnPointX = 28;
    private int _minimumSpawnPointX = -5;
    private int _maximumSpawnPointY = 0;
    private int _minimumSpawnPointY = -2;

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    
    private IEnumerator Spawn()
    {
        while (true)
        {
            _randomX = Random.Range(_minimumSpawnPointX, _maximumSpawnPointX);
            _randomY = Random.Range(_minimumSpawnPointY, _maximumSpawnPointY);
           _spawnPoint.position = new Vector2 (_randomX, _randomY);
            Instantiate(_money, _spawnPoint.position,Quaternion.identity);            
            yield return _waitForSeconds;
        }
    }
}
