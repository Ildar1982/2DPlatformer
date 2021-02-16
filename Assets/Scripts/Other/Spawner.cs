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

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    
    private IEnumerator Spawn()
    {
        while (true)
        {
            _randomX = Random.Range(-5, 28);
            _randomY = Random.Range(-2, 0);
           _spawnPoint.position = new Vector2 (_randomX, _randomY);
            Instantiate(_money, _spawnPoint.position,Quaternion.identity);            
            yield return _waitForSeconds;
        }
    }
}
