using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SpawnedThrowable : MonoBehaviour
{
    private ThrowableSpawner spawnManager;
    private int spawnIndex;
    private bool releasedSpawnPoint;

    public void Initialize(ThrowableSpawner manager, int index)
    {
        spawnManager = manager;
        spawnIndex = index;
    }

    private void Update()
    {
        if (releasedSpawnPoint)
            return;

        XRGrabInteractable grab =
            GetComponent<XRGrabInteractable>();

        if (grab != null && grab.isSelected)
        {
            releasedSpawnPoint = true;

            spawnManager.ClearObject(spawnIndex);
        }
    }
}