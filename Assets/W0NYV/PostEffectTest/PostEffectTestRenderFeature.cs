using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[Serializable]
public class PostEffectTestRenderFeature : ScriptableRendererFeature
{
    [SerializeField] private Shader _shader;
    [SerializeField] private PostprocessTiming _timing = PostprocessTiming.AfterOpaque;
    [SerializeField] private bool _applyToSceneView = true;

    private PostEffectTestRenderPass _postProcessPass;

    public override void Create()
    {
        _postProcessPass = new PostEffectTestRenderPass(_applyToSceneView, _shader);
    }

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        _postProcessPass.Setup(renderer.cameraColorTarget, _timing);
        renderer.EnqueuePass(_postProcessPass);
    }
}
