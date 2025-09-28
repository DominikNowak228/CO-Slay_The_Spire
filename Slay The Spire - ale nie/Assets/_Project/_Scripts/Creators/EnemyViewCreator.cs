using UnityEngine;

public class EnemyViewCreator : Singleton<EnemyViewCreator>
{
    [SerializeField] private EnemyView enemyViewPrefab;

    public EnemyView CreateEnemyView(EnemyData enemyData, Vector3 pos, Quaternion rot)
    {
        EnemyView enemyView = Instantiate(enemyViewPrefab, pos, rot);
        enemyView.Setup(enemyData);
        return enemyView;
    }
}
