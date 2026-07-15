using System.Collections.Generic;
using UnityEngine;

public class VelocityTracker : MonoBehaviour
{
    [SerializeField]
    private int sampleCount = 5;

    private readonly Queue<ThrowSample> samples = new();

    private void LateUpdate()
    {
        samples.Enqueue(new ThrowSample
        {
            position = transform.position,
            time = Time.time
        });

        while (samples.Count > sampleCount)
        {
            samples.Dequeue();
        }
    }

    public Vector3 GetVelocity()
    {
        if (samples.Count < 2)
            return Vector3.zero;

        ThrowSample[] buffer = samples.ToArray();

        Vector3 velocitySum = Vector3.zero;
        int validSamples = 0;

        for (int i = 1; i < buffer.Length; i++)
        {
            float dt = buffer[i].time - buffer[i - 1].time;

            if (dt <= 0f)
                continue;

            Vector3 frameVelocity =
                (buffer[i].position - buffer[i - 1].position) / dt;

            velocitySum += frameVelocity;
            validSamples++;
        }

        if (validSamples == 0)
            return Vector3.zero;

        return velocitySum / validSamples;
    }
}