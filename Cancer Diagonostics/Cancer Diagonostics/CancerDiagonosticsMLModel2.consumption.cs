﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace Cancer_Diagonostics
{
    public partial class CancerDiagonosticsMLModel2
    {
        /// <summary>
        /// model input class for CancerDiagonosticsMLModel2.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"GENDER")]
            public string GENDER { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"AGE")]
            public float AGE { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"SMOKING")]
            public float SMOKING { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"YELLOW_FINGERS")]
            public float YELLOW_FINGERS { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"ANXIETY")]
            public float ANXIETY { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"PEER_PRESSURE")]
            public float PEER_PRESSURE { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"CHRONIC DISEASE")]
            public float CHRONIC_DISEASE { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"FATIGUE")]
            public float FATIGUE { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"ALLERGY")]
            public float ALLERGY { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"WHEEZING")]
            public float WHEEZING { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"ALCOHOL CONSUMING")]
            public float ALCOHOL_CONSUMING { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"COUGHING")]
            public float COUGHING { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"SHORTNESS OF BREATH")]
            public float SHORTNESS_OF_BREATH { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"SWALLOWING DIFFICULTY")]
            public float SWALLOWING_DIFFICULTY { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"CHEST PAIN")]
            public float CHEST_PAIN { get; set; }

            [LoadColumn(15)]
            [ColumnName(@"LUNG_CANCER")]
            public bool LUNG_CANCER { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for CancerDiagonosticsMLModel2.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"GENDER")]
            public float[] GENDER { get; set; }

            [ColumnName(@"AGE")]
            public float AGE { get; set; }

            [ColumnName(@"SMOKING")]
            public float SMOKING { get; set; }

            [ColumnName(@"YELLOW_FINGERS")]
            public float YELLOW_FINGERS { get; set; }

            [ColumnName(@"ANXIETY")]
            public float ANXIETY { get; set; }

            [ColumnName(@"PEER_PRESSURE")]
            public float PEER_PRESSURE { get; set; }

            [ColumnName(@"CHRONIC DISEASE")]
            public float CHRONIC_DISEASE { get; set; }

            [ColumnName(@"FATIGUE")]
            public float FATIGUE { get; set; }

            [ColumnName(@"ALLERGY")]
            public float ALLERGY { get; set; }

            [ColumnName(@"WHEEZING")]
            public float WHEEZING { get; set; }

            [ColumnName(@"ALCOHOL CONSUMING")]
            public float ALCOHOL_CONSUMING { get; set; }

            [ColumnName(@"COUGHING")]
            public float COUGHING { get; set; }

            [ColumnName(@"SHORTNESS OF BREATH")]
            public float SHORTNESS_OF_BREATH { get; set; }

            [ColumnName(@"SWALLOWING DIFFICULTY")]
            public float SWALLOWING_DIFFICULTY { get; set; }

            [ColumnName(@"CHEST PAIN")]
            public float CHEST_PAIN { get; set; }

            [ColumnName(@"LUNG_CANCER")]
            public bool LUNG_CANCER { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public bool PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

            [ColumnName(@"Probability")]
            public float Probability { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("CancerDiagonosticsMLModel2.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
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
