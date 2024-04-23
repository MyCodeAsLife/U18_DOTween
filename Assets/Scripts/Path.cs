using DG.Tweening;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;

    private void Start()
    {
        Tween tween = transform.DOPath(_waypoints, 5f, PathType.CatmullRom).
                                SetOptions(true).               
                                SetLookAt(0.01f).               
                                SetLoops(-1).                 
                                SetEase(Ease.Linear);           

    }
}
