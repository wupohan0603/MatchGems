using System;
using UnityEngine;

//避免衝突 要自己用一個核心命名空間(消除寶石)
namespace MatchGem.Core
{
    /// <summary>
    /// 棋盤格尺寸設定
    /// </summary>
    public class GridSettings : MonoBehaviour
    {
        #region 基本參數 
        [SerializeField] private int _cellSize = 64; //底線 私變數
        [SerializeField] private float _pixelPerUnit = 64f;
        #endregion 基本參數


        private void Start()
        {
            Debug.Log(_cellSize);
        }

        private void Update()
        {
            Debug.Log(_cellSize);
        }
    }
}