using DG.Tweening;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private void Start()
    {
        _renderer.material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
