using UnityEngine;

public class SpawnButtonHandler : MonoBehaviour
{
    [SerializeField]
    private ThrowableSpawner spawner;

    public void SpawnBall()
    {
        spawner.SpawnObject(0);
    }

    public void SpawnCube()
    {
        spawner.SpawnObject(1);
    }

    public void SpawnDart()
    {
        spawner.SpawnObject(2);
    }
}