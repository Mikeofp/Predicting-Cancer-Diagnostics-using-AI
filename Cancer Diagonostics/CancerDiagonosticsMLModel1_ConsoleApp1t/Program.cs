﻿
// This file was auto-generated by ML.NET Model Builder. 

using CancerDiagonosticsMLModel1_ConsoleApp1t;

// Create single instance of sample data from first line of dataset for model input
CancerDiagonosticsMLModel1.ModelInput sampleData = new CancerDiagonosticsMLModel1.ModelInput()
{
    Radius_mean = 20.57F,
    Texture_mean = 17.77F,
    Perimeter_mean = 132.9F,
    Area_mean = 1326F,
    Smoothness_mean = 0.08474F,
    Compactness_mean = 0.07864F,
    Concavity_mean = 0.0869F,
    Concave_points_mean = 0.07017F,
    Symmetry_mean = 0.1812F,
    Fractal_dimension_mean = 0.05667F,
    Radius_se = 0.5435F,
    Texture_se = 0.7339F,
    Perimeter_se = 3.398F,
    Area_se = 74.08F,
    Smoothness_se = 0.005225F,
    Compactness_se = 0.01308F,
    Concavity_se = 0.0186F,
    Concave_points_se = 0.0134F,
    Symmetry_se = 0.01389F,
    Fractal_dimension_se = 0.003532F,
    Radius_worst = 24.99F,
    Texture_worst = 23.41F,
    Perimeter_worst = 158.8F,
    Area_worst = 1956F,
    Smoothness_worst = 0.1238F,
    Compactness_worst = 0.1866F,
    Concavity_worst = 0.2416F,
    Concave_points_worst = 0.186F,
    Symmetry_worst = 0.275F,
    Fractal_dimension_worst = 0.08902F,
};



Console.WriteLine("Using model to make single prediction -- Comparing actual Diagnosis with predicted Diagnosis from sample data...\n\n");


Console.WriteLine($"Diagnosis: {@"M"}");
Console.WriteLine($"Radius_mean: {20.57F}");
Console.WriteLine($"Texture_mean: {17.77F}");
Console.WriteLine($"Perimeter_mean: {132.9F}");
Console.WriteLine($"Area_mean: {1326F}");
Console.WriteLine($"Smoothness_mean: {0.08474F}");
Console.WriteLine($"Compactness_mean: {0.07864F}");
Console.WriteLine($"Concavity_mean: {0.0869F}");
Console.WriteLine($"Concave_points_mean: {0.07017F}");
Console.WriteLine($"Symmetry_mean: {0.1812F}");
Console.WriteLine($"Fractal_dimension_mean: {0.05667F}");
Console.WriteLine($"Radius_se: {0.5435F}");
Console.WriteLine($"Texture_se: {0.7339F}");
Console.WriteLine($"Perimeter_se: {3.398F}");
Console.WriteLine($"Area_se: {74.08F}");
Console.WriteLine($"Smoothness_se: {0.005225F}");
Console.WriteLine($"Compactness_se: {0.01308F}");
Console.WriteLine($"Concavity_se: {0.0186F}");
Console.WriteLine($"Concave_points_se: {0.0134F}");
Console.WriteLine($"Symmetry_se: {0.01389F}");
Console.WriteLine($"Fractal_dimension_se: {0.003532F}");
Console.WriteLine($"Radius_worst: {24.99F}");
Console.WriteLine($"Texture_worst: {23.41F}");
Console.WriteLine($"Perimeter_worst: {158.8F}");
Console.WriteLine($"Area_worst: {1956F}");
Console.WriteLine($"Smoothness_worst: {0.1238F}");
Console.WriteLine($"Compactness_worst: {0.1866F}");
Console.WriteLine($"Concavity_worst: {0.2416F}");
Console.WriteLine($"Concave_points_worst: {0.186F}");
Console.WriteLine($"Symmetry_worst: {0.275F}");
Console.WriteLine($"Fractal_dimension_worst: {0.08902F}");


var sortedScoresWithLabel = CancerDiagonosticsMLModel1.PredictAllLabels(sampleData);
Console.WriteLine($"{"Class",-40}{"Score",-20}");
Console.WriteLine($"{"-----",-40}{"-----",-20}");

foreach (var score in sortedScoresWithLabel)
{
    Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
}

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

