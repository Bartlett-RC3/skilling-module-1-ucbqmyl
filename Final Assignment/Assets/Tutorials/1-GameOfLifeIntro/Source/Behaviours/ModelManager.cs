using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using SpatialSlur;

namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelManager : MonoBehaviour
    {
        [SerializeField] private ModelInitializer _initializer;
        [SerializeField] private Cell _cellPrefab;
        [SerializeField] private int _countX = 10;
        [SerializeField] private int _countY = 10;
        [SerializeField] private Material _material;

        [SerializeField] private int _ageDisplayMin = 0;
        [SerializeField] private int _ageDisplayMax = 10;

        private MaterialPropertyBlock _properties;

        private Cell[,] _cells;
        private GameOfLife2D _model;
        private int _stepCount;


        private List<int> _totalcells = new List<int>();
        private int _calculate = 0;

      

        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            _properties = new MaterialPropertyBlock();
            // create cell array
            _cells = new Cell[_countY, _countX];


            // instantiate cell prefabs and store in array
            for (int y = 0; y < _countY; y++)
            {
                for(int x = 0; x < _countX; x++)
                {
                    Cell cell = Instantiate(_cellPrefab, transform);
                    cell.transform.localPosition = new Vector3(x, y, 0);
                    _cells[y, x] = cell;
                    //cell.Renderer.GetComponent<MeshRenderer>().material = _material;
                }
            }

           
           


            //Debug.Log("b");
            // create model
            _model = new GameOfLife2D(_countY, _countX);

            // initialize model
            _initializer.Initialize(_model.CurrentState);


        }


        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {

            _model.Step();
            _stepCount++;
            // Debug.Log($"{_stepCount} steps taken!");

            int[,] state = _model.CurrentState;



            // update cells based on current state of model
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                {
                    _cells[y, x].State = state[y, x];
                    _calculate = _calculate + state[y, x];

                    _cells[y, x].Age = state[y, x] > 0 ? _cells[y, x].Age + 1 : 0;
                }
            }

            //Debug.Log("Age" +_cells[1, 1].Age);

            _totalcells.Add(_calculate);
            _calculate = 0;

            for(int i=0;i<_totalcells.Count;i++)
            Debug.Log("Total cells is " +_totalcells[i]);

            DisplayColor();

            Debug.Log("StartCoroutine");
            StartCoroutine(DisplayColor());

            Debug.Log(Time.time);


        


            //Debug.Log("e");
            if (Time.time > 5)
            {

                StopCoroutine(DisplayColor());
                Debug.Log("StopCoroutine");
                StopAllCoroutines();
                Debug.Log("StopAllCoroutines");
            }


        }

        IEnumerator DisplayColor()
        {
            const string propName = "_Value";
            //Debug.Log("f");
            //Cell cell = Instantiate(_cellPrefab, transform);
            foreach (var cell in _cells)
            {
                if (cell.State == 0)
                    continue;

                MeshRenderer renderer = cell.Renderer;
                renderer.sharedMaterial = _material;

                renderer.GetPropertyBlock(_properties);

                 float value = SlurMath.Normalize(cell.Age, _ageDisplayMin, _ageDisplayMax);
                 _properties.SetFloat(propName, value);

                 renderer.SetPropertyBlock(_properties);

            }


            yield return new WaitForSeconds(3f);
            Debug.Log("WaitForSeconds------------------------------------");
        }


    }
}
