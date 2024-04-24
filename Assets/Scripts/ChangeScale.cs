using DG.Tweening;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    private void Start()
    {
        const float Scale = 3f;
        const float Duration = 3f;

        transform.DOScale(Scale, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
