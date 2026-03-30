using UnityEngine;

public class PourOnGrab : MonoBehaviour
{
    public ParticleSystem pourEffect;

    public void StartPour()
    {
        pourEffect.Play();
    }

    public void StopPour()
    {
        pourEffect.Stop();
    }
}