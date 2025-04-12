using System.Data;
using Microsoft.ML;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用数据生成模型
            //string _modelPath = Path.Combine(Environment.CurrentDirectory, "data", "IrisClusteringModel.zip");
            string _modelPath = Path.Combine(AppContext.BaseDirectory, "Data", "IrisClusteringModel.zip");
            var mlContext = new MLContext(seed: 0);
            

            // 使用模型做预测
            string featuresColumnName = "Features";
            // pipeline
            var pipeline = mlContext.Transforms
                .Concatenate(featuresColumnName, "SepalLength", "SepalWidth", "PetalLength", "PetalWidth")
                .Append(mlContext.Clustering.Trainers.KMeans(featuresColumnName, numberOfClusters: 3));

            // model, 数据按照pipeline设计的路径，生成model  
            //var model = pipeline.Fit(dataView);
            ITransformer model = mlContext.Model.Load(_modelPath, out _);

            // 存model
            //using (var fileStream = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
            //{
            //    mlContext.Model.Save(model, dataView.Schema, fileStream);
            //}

            // Use the model for predictions 模型生成预测
            //PredictionEngine 是一个便捷的 API，可用于对单个数据实例执行预测。PredictionEngine 并非线程安全的。
            //它适用于单线程或原型环境。
            //为了在生产环境中提升性能和线程安全性，
            //请使用 PredictionEnginePool 服务，该服务会创建一个包含 PredictionEngine 对象的 ObjectPool，供整个应用程序使用。
            //请参阅本指南，了解如何在 ASP.NET Core Web API 中使用 PredictionEnginePool。
            var predictor = mlContext.Model.CreatePredictionEngine<IrisData, ClusterPrediction>(model);

            var prediction = predictor.Predict(TestIrisData.Setosa);
            Console.WriteLine($"Cluster: {prediction.PredictedClusterId}");
            Console.WriteLine($"Distances: {string.Join(" ", prediction.Distances ?? Array.Empty<float>())}");

        }
    }
}
