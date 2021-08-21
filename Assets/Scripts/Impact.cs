using UnityEngine;

public class Impact : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private PunchingBagParameters _bagParameters;
    [SerializeField] private PunchingBag _punchingBag;
    [SerializeField] private PowerScale _powerScale;
    [SerializeField] private RenderImpactStrength _renderImpactStrength;
    [SerializeField] private NotebookTracking _notebookTracking;

    public void Hit(string animationName, float rateForIncreasedVibration = 1f)
    {
        _powerScale.StopSliderChanges();
        _playerAnimator.Play(animationName);
        _punchingBag.Hesitate(_bagParameters.SwingDirectionBag,
            _bagParameters.VibrationForce * rateForIncreasedVibration);
        _punchingBag.Celebrate();
        StartCoroutine(_renderImpactStrength.Display(_powerScale.Slider.value));
        StartCoroutine(_notebookTracking.Track());
    }
}