using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyWave[] enemyWaves;

    private int currentWave;

    void Start()
    {
        SpawnEnemyWave();
    }

    void SpawnEnemyWave()
    {
        EnemyWave waveInfo = enemyWaves[currentWave];
        Vector3 startPosition = waveInfo.flyPath[0];

        for (int i = 0; i < waveInfo.numberOfEnemy; i++)
        {
            Transform enemy = Instantiate(
                waveInfo.enemyPrefab,
                startPosition,
                Quaternion.identity
            );

            FlyPathAgent agent = enemy.GetComponent<FlyPathAgent>();
            agent.flyPath = waveInfo.flyPath;
            agent.flySpeed = waveInfo.speed;

            startPosition += waveInfo.formationOffset;
        }

        currentWave++;

        if (currentWave < enemyWaves.Length)
        {
            Invoke(nameof(SpawnEnemyWave), waveInfo.nextWaveDelay);
        }
    }
}
