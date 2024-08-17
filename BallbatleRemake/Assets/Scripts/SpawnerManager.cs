using System.Collections;
using UnityEngine;

public class SpawnerManager : DeathZone
{
    [SerializeField] private GameObject[] _allEnemys;
    [SerializeField] private GameObject _powerUp;

    private float _rangeXPosition = 7;
    private float _rangeZPosition = 11;

    private float _spawnDelay = 5;
    private int _wafeEnemy = 2;

    private void Start()
    {
        SpawnPowerUp();
        SpawnEnemy(1);
        StartCoroutine(EnemyCountDownRoutine());
    }

    private IEnumerator EnemyCountDownRoutine()
    {
        if (isGame == true)
        {
            yield return new WaitForSeconds(_spawnDelay);
            SpawnEnemy(_wafeEnemy++);
            SpawnPowerUp();
            _spawnDelay += 2;
        }
    }

    private int RandomEnemy()
    {
        int numberOfEnemy = Random.Range(0, 3);
        return numberOfEnemy;
    }

    private Vector3 GenerateRandomPosition()
    {
        float randomPosX = Random.Range(-_rangeXPosition, _rangeXPosition);
        float randomPosZ = Random.Range(-_rangeZPosition, _rangeZPosition);

        Vector3 enemyPos = new Vector3(randomPosX, 0, randomPosZ);
        return enemyPos;
    }

    private void SpawnEnemy(int enemyToSpawn)
    {
        for (int i = 0; i < enemyToSpawn; i++)
        Instantiate(_allEnemys[RandomEnemy()], GenerateRandomPosition(), _allEnemys[RandomEnemy()].transform.rotation);
    }

    private void SpawnPowerUp()
    {
        Instantiate(_powerUp, GenerateRandomPosition(), _powerUp.transform.rotation);
    }
}