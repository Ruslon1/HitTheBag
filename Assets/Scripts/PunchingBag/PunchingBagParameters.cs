using UnityEngine;

public class PunchingBagParameters : MonoBehaviour
{
    [SerializeField] private Vector3 _swingDirectionBag;
    [SerializeField] private float _vibrationForce;

    public Vector3 SwingDirectionBag => _swingDirectionBag;
    public float VibrationForce  => _vibrationForce;
}