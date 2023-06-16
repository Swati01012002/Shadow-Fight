using UnityEngine;

public class ParticleActivation : MonoBehaviour
{
    private new ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop(); // Ensure the particle system is initially stopped
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            ActivateParticleSystem();
        }
    }

    private void ActivateParticleSystem()
    {
        particleSystem.Play();
    }
}
