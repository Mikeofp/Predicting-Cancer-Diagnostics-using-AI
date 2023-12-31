﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace CancerDiagonosticsMLModel1_ConsoleApp1t
{
    public partial class CancerDiagonosticsMLModel1
    {
        /// <summary>
        /// model input class for CancerDiagonosticsMLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"diagnosis")]
            public string Diagnosis { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"radius_mean")]
            public float Radius_mean { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"texture_mean")]
            public float Texture_mean { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"perimeter_mean")]
            public float Perimeter_mean { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"area_mean")]
            public float Area_mean { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"smoothness_mean")]
            public float Smoothness_mean { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"compactness_mean")]
            public float Compactness_mean { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"concavity_mean")]
            public float Concavity_mean { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"concave points_mean")]
            public float Concave_points_mean { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"symmetry_mean")]
            public float Symmetry_mean { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"fractal_dimension_mean")]
            public float Fractal_dimension_mean { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"radius_se")]
            public float Radius_se { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"texture_se")]
            public float Texture_se { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"perimeter_se")]
            public float Perimeter_se { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"area_se")]
            public float Area_se { get; set; }

            [LoadColumn(15)]
            [ColumnName(@"smoothness_se")]
            public float Smoothness_se { get; set; }

            [LoadColumn(16)]
            [ColumnName(@"compactness_se")]
            public float Compactness_se { get; set; }

            [LoadColumn(17)]
            [ColumnName(@"concavity_se")]
            public float Concavity_se { get; set; }

            [LoadColumn(18)]
            [ColumnName(@"concave points_se")]
            public float Concave_points_se { get; set; }

            [LoadColumn(19)]
            [ColumnName(@"symmetry_se")]
            public float Symmetry_se { get; set; }

            [LoadColumn(20)]
            [ColumnName(@"fractal_dimension_se")]
            public float Fractal_dimension_se { get; set; }

            [LoadColumn(21)]
            [ColumnName(@"radius_worst")]
            public float Radius_worst { get; set; }

            [LoadColumn(22)]
            [ColumnName(@"texture_worst")]
            public float Texture_worst { get; set; }

            [LoadColumn(23)]
            [ColumnName(@"perimeter_worst")]
            public float Perimeter_worst { get; set; }

            [LoadColumn(24)]
            [ColumnName(@"area_worst")]
            public float Area_worst { get; set; }

            [LoadColumn(25)]
            [ColumnName(@"smoothness_worst")]
            public float Smoothness_worst { get; set; }

            [LoadColumn(26)]
            [ColumnName(@"compactness_worst")]
            public float Compactness_worst { get; set; }

            [LoadColumn(27)]
            [ColumnName(@"concavity_worst")]
            public float Concavity_worst { get; set; }

            [LoadColumn(28)]
            [ColumnName(@"concave points_worst")]
            public float Concave_points_worst { get; set; }

            [LoadColumn(29)]
            [ColumnName(@"symmetry_worst")]
            public float Symmetry_worst { get; set; }

            [LoadColumn(30)]
            [ColumnName(@"fractal_dimension_worst")]
            public float Fractal_dimension_worst { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for CancerDiagonosticsMLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"diagnosis")]
            public uint Diagnosis { get; set; }

            [ColumnName(@"radius_mean")]
            public float Radius_mean { get; set; }

            [ColumnName(@"texture_mean")]
            public float Texture_mean { get; set; }

            [ColumnName(@"perimeter_mean")]
            public float Perimeter_mean { get; set; }

            [ColumnName(@"area_mean")]
            public float Area_mean { get; set; }

            [ColumnName(@"smoothness_mean")]
            public float Smoothness_mean { get; set; }

            [ColumnName(@"compactness_mean")]
            public float Compactness_mean { get; set; }

            [ColumnName(@"concavity_mean")]
            public float Concavity_mean { get; set; }

            [ColumnName(@"concave points_mean")]
            public float Concave_points_mean { get; set; }

            [ColumnName(@"symmetry_mean")]
            public float Symmetry_mean { get; set; }

            [ColumnName(@"fractal_dimension_mean")]
            public float Fractal_dimension_mean { get; set; }

            [ColumnName(@"radius_se")]
            public float Radius_se { get; set; }

            [ColumnName(@"texture_se")]
            public float Texture_se { get; set; }

            [ColumnName(@"perimeter_se")]
            public float Perimeter_se { get; set; }

            [ColumnName(@"area_se")]
            public float Area_se { get; set; }

            [ColumnName(@"smoothness_se")]
            public float Smoothness_se { get; set; }

            [ColumnName(@"compactness_se")]
            public float Compactness_se { get; set; }

            [ColumnName(@"concavity_se")]
            public float Concavity_se { get; set; }

            [ColumnName(@"concave points_se")]
            public float Concave_points_se { get; set; }

            [ColumnName(@"symmetry_se")]
            public float Symmetry_se { get; set; }

            [ColumnName(@"fractal_dimension_se")]
            public float Fractal_dimension_se { get; set; }

            [ColumnName(@"radius_worst")]
            public float Radius_worst { get; set; }

            [ColumnName(@"texture_worst")]
            public float Texture_worst { get; set; }

            [ColumnName(@"perimeter_worst")]
            public float Perimeter_worst { get; set; }

            [ColumnName(@"area_worst")]
            public float Area_worst { get; set; }

            [ColumnName(@"smoothness_worst")]
            public float Smoothness_worst { get; set; }

            [ColumnName(@"compactness_worst")]
            public float Compactness_worst { get; set; }

            [ColumnName(@"concavity_worst")]
            public float Concavity_worst { get; set; }

            [ColumnName(@"concave points_worst")]
            public float Concave_points_worst { get; set; }

            [ColumnName(@"symmetry_worst")]
            public float Symmetry_worst { get; set; }

            [ColumnName(@"fractal_dimension_worst")]
            public float Fractal_dimension_worst { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public string PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("CancerDiagonosticsMLModel1.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict scores for all possible labels.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static IOrderedEnumerable<KeyValuePair<string, float>> PredictAllLabels(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            var result = predEngine.Predict(input);
            return GetSortedScoresWithLabels(result);
        }

        /// <summary>
        /// Map the unlabeled result score array to the predicted label names.
        /// </summary>
        /// <param name="result">Prediction to get the labeled scores from.</param>
        /// <returns>Ordered list of label and score.</returns>
        /// <exception cref="Exception"></exception>
        public static IOrderedEnumerable<KeyValuePair<string, float>> GetSortedScoresWithLabels(ModelOutput result)
        {
            var unlabeledScores = result.Score;
            var labelNames = GetLabels(result);

            Dictionary<string, float> labledScores = new Dictionary<string, float>();
            for (int i = 0; i < labelNames.Count(); i++)
            {
                // Map the names to the predicted result score array
                var labelName = labelNames.ElementAt(i);
                labledScores.Add(labelName.ToString(), unlabeledScores[i]);
            }

            return labledScores.OrderByDescending(c => c.Value);
        }

        /// <summary>
        /// Get the ordered label names.
        /// </summary>
        /// <param name="result">Predicted result to get the labels from.</param>
        /// <returns>List of labels.</returns>
        /// <exception cref="Exception"></exception>
        private static IEnumerable<string> GetLabels(ModelOutput result)
        {
            var schema = PredictEngine.Value.OutputSchema;

            var labelColumn = schema.GetColumnOrNull("diagnosis");
            if (labelColumn == null)
            {
                throw new Exception("diagnosis column not found. Make sure the name searched for matches the name in the schema.");
            }

            // Key values contains an ordered array of the possible labels. This allows us to map the results to the correct label value.
            var keyNames = new VBuffer<ReadOnlyMemory<char>>();
            labelColumn.Value.GetKeyValues(ref keyNames);
            return keyNames.DenseValues().Select(x => x.ToString());
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}
