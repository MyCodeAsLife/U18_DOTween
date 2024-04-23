using DG.Tweening;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(3f, 3f).SetLoops(-1, LoopType.Yoyo);
    }
}
