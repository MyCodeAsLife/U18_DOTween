using DG.Tweening;
using UnityEngine;

public class ChangeRotate : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(60f, 15f, 0), 2f).SetLoops(-1, LoopType.Yoyo);
    }
}
