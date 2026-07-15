using UnityEngine;

public class TargetHit : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private Renderer targetRenderer;

    [SerializeField]
    private Color hitColor =
        Color.green;

    private Color original;

    private void Start()
    {
        original =
            targetRenderer.material.color;
    }

    private void OnCollisionEnter(
        Collision collision)
    {
        if(collision.gameObject
            .GetComponent<Throwable>())
        {
            audioSource.Play();

            targetRenderer.material.color
                = hitColor;

            Invoke(nameof(ResetColor), 0.5f);
        }
    }

    private void ResetColor()
    {
        targetRenderer.material.color
            = original;
    }
}