public class EnemyHealth : Health
{
    public static int livingEnemyCount; // bien dem so luong enemy con song trong scene
    private void Awake()
    {
        livingEnemyCount++;
    }
    

    protected override void Die()
    {
        livingEnemyCount--; // giam so luong enemy con song khi co 1 enemy chet
        base.Die();
        
    }
}
