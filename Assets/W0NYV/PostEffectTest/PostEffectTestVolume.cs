using System;
using UnityEngine;
using UnityEngine.Rendering;

[Serializable]
[VolumeComponentMenu("Post Effect Test")]
public class PostEffectTestVolume : VolumeComponent
{
    public bool IsActive() => tintColor != Color.white;

    public ColorParameter tintColor = new ColorParameter(Color.white);
}
