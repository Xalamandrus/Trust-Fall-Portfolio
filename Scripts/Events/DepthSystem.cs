using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DepthSystem : MonoSingleton<DepthSystem>
{
    [SerializeField] private Text _textMesh;

    [SerializeField] private int _maxDepth = 100;
    private int _currentDepth = 0;

    private void Update()
    {
        _currentDepth = PoolingMapManager.Instance.Get_PoolUsed();

        if (_currentDepth <= _maxDepth)
        {
            _textMesh.text = "Depth: " + _currentDepth.ToString();
        }
        else
        {
            //SceneManager.LoadScene();
        }
    }

    public int Get_MaxDepth() {  return _maxDepth; }

    public int Get_CurrentDepth() { return _currentDepth; }
}