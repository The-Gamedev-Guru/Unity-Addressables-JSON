using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class PrintAddressablesTextLength : MonoBehaviour
{
    [SerializeField] private AssetReference _addressableTextAsset = null;

    void Start()
    {
        _addressableTextAsset.LoadAssetAsync<TextAsset>().Completed += handle =>
        {
            Debug.Log($"Length: {handle.Result.text.Length}");
            Addressables.Release(handle);
        };
    }
}
