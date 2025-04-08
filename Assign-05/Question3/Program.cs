using Microsoft.ML;
using Question3.data;
using Question3;
using System.Data;





string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "StudentData.csv");
string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "StudentClusteringModel.zip");
var mlContext = new MLContext(seed: 0);

// Load data          
IDataView dataView = mlContext.Data.LoadFromTextFile<StudentData>(_dataPath, hasHeader: true, separatorChar: ',');
            
// Create a learning pipeline
string featuresColumnName = "Features";
var pipeline = mlContext.Transforms
    .Concatenate(featuresColumnName, 
    "STG","SCG","STR","LPR","PEG")
    .Append(mlContext.Clustering.Trainers.KMeans(featuresColumnName, numberOfClusters: 4));

// train the model
var model = pipeline.Fit(dataView);

// Save the model
using (var fileStream = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
{
    mlContext.Model.Save(model, dataView.Schema, fileStream);
}

// Use the model for predictions
var predictor = mlContext.Model.CreatePredictionEngine<StudentData, ClusterPrediction>(model);

// To find out the cluster to which the specified item belongs to
var prediction = predictor.Predict(TestStartData.case1);
Console.WriteLine($"Cluster: {prediction.PredictedClusterId}");
Console.WriteLine($"Distances: {string.Join(" ", prediction.Distances ?? Array.Empty<float>())}");


prediction = predictor.Predict(TestStartData.case2);
Console.WriteLine($"Cluster: {prediction.PredictedClusterId}");
Console.WriteLine($"Distances: {string.Join(" ", prediction.Distances ?? Array.Empty<float>())}");

prediction = predictor.Predict(TestStartData.case3);
Console.WriteLine($"Cluster: {prediction.PredictedClusterId}");
Console.WriteLine($"Distances: {string.Join(" ", prediction.Distances ?? Array.Empty<float>())}");