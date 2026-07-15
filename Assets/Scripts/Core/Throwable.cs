using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
public class Throwable : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
{
    [Header("Throw Settings")]
    [SerializeField] private float throwMultiplier = 1.2f;
    [SerializeField] private float maxThrowSpeed = 8f;

    private Rigidbody rb;
    private VelocityTracker velocityTracker;

    protected override void Awake()
    {
        base.Awake();

        rb = GetComponent<Rigidbody>();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        velocityTracker =
            args.interactorObject.transform.GetComponent<VelocityTracker>();

        rb.isKinematic = true;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);

        rb.isKinematic = false;

        if (velocityTracker == null)
            return;

        Vector3 throwVelocity =
            velocityTracker.GetVelocity() * throwMultiplier;

        throwVelocity =
            Vector3.ClampMagnitude(throwVelocity, maxThrowSpeed);

        rb.linearVelocity = throwVelocity;

        Debug.Log($"Throw Velocity: {throwVelocity}");
    }
}