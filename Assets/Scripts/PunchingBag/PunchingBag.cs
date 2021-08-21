using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PunchingBag : MonoBehaviour, IPunchingBag
{
    [SerializeField] private Rigidbody _bagRigidbody;
    [SerializeField] private Slider _powerScaleSlider;
    [SerializeField] private ParticleSystem[] _effectCongratulations;

    public void Hesitate(Vector3 direction, float vibrationForce)
    {
        _bagRigidbody.AddForce(direction * vibrationForce * _powerScaleSlider.value);
    }

    public void Celebrate()
    {
        foreach (var effect in _effectCongratulations)
        {
            effect.Play();
        }
    }
}