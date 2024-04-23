using DG.Tweening;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    private void Start()
    {
        float scale = 3f;
        float duration = 3f;

        transform.DOScale(scale, duration).SetLoops(-1, LoopType.Yoyo);
    }
}
