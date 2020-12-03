using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.SceneUnderstanding.Samples.Unity;

public class NearMenuControls : MonoBehaviour
{
    [SerializeField]
    private FastSceneUnderstandingManager sceneUnderstandingManager;
    [SerializeField]
    private Interactable AutoRefreshToggle;
    [SerializeField]
    private Interactable InferRegionsToggle;

    private void Start()
    {
        AutoRefreshToggle.IsToggled = sceneUnderstandingManager.AutoRefresh;
        InferRegionsToggle.IsToggled = sceneUnderstandingManager.RequestInferredRegions;
    }

    public void UpdateSU()
    {
        sceneUnderstandingManager.StartDisplay();
    }

    public void ToggleAutoRefresh(bool enabled)
    {
        sceneUnderstandingManager.AutoRefresh = enabled;
        if (!sceneUnderstandingManager.AutoRefresh)
        {
            // sceneUnderstandingManager.TimeElapsedSinceLastAutoRefresh = sceneUnderstandingManager.AutoRefreshIntervalInSeconds;
        }
    }

    public void UseMeshRenderingMode()
    {
        sceneUnderstandingManager.SceneObjectRequestMode = Microsoft.MixedReality.SceneUnderstanding.Samples.Unity.RenderMode.Mesh;
    }

    public void UseQuadRenderingMode()
    {
        sceneUnderstandingManager.SceneObjectRequestMode = Microsoft.MixedReality.SceneUnderstanding.Samples.Unity.RenderMode.Quad;
    }

    public void ToggleInferRegions(bool enabled)
    {
        sceneUnderstandingManager.RequestInferredRegions = enabled;
    }
}
