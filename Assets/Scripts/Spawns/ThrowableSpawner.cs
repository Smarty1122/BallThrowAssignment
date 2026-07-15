using UnityEngine;

public class ThrowableSpawner : MonoBehaviour
{
    [System.Serializable]
    public class SpawnData
    {
        public GameObject prefab;
        public Transform spawnPoint;

        [HideInInspector]
        public GameObject currentInstance;
    }

    [SerializeField]
    private SpawnData[] throwableData;

    public void SpawnObject(int index)
    {
        if (index < 0 || index >= throwableData.Length)
            return;

        SpawnData data = throwableData[index];

        // Already exists at spawn point
        if (data.currentInstance != null)
            return;

        data.currentInstance =
            Instantiate(
                data.prefab,
                data.spawnPoint.position,
                data.spawnPoint.rotation);

        SpawnedThrowable spawned =
            data.currentInstance.AddComponent<SpawnedThrowable>();

        spawned.Initialize(this, index);
    }

    public void ClearObject(int index)
    {
        if (index < 0 || index >= throwableData.Length)
            return;

        throwableData[index].currentInstance = null;
    }
}