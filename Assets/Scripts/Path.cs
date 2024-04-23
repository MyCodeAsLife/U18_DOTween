using DG.Tweening;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;

    private void Start()
    {
        const float Duration = 5f;
        const float LookAhead = 0.01f;

        Tween tween = transform.DOPath(_waypoints, Duration, PathType.CatmullRom).
                                SetOptions(true).
                                SetLookAt(LookAhead).
                                SetLoops(-1).
                                SetEase(Ease.Linear);
    }
}
