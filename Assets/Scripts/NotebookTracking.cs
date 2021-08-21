using System.Collections;
using UnityEngine;
using DG.Tweening;

public class NotebookTracking : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private Vector3 _targetRotation;

    public IEnumerator Track()
    {
        yield return new WaitForSeconds(3f);

        gameObject.transform.DOMove(_targetPosition, 2);
        gameObject.transform.DORotate(_targetRotation, 2);
    }
}