using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using static System.Formats.Asn1.AsnWriter;

namespace Test
{
    //IrisData 是输入数据类，其中包含数据集中每个特征的定义。
    //使用 LoadColumn 属性指定数据集文件中源列的索引。
    public class IrisData
    {
        [LoadColumn(0)]
        public float SepalLength;

        [LoadColumn(1)]
        public float SepalWidth;

        [LoadColumn(2)]
        public float PetalLength;

        [LoadColumn(3)]
        public float PetalWidth;
    }

    //ClusterPrediction 类表示应用于 IrisData 实例的聚类模型的输出。
    //使用 ColumnName 属性将 PredictedClusterId 和 Distances 字段分别绑定到 PredictedLabel 和 Score 列。
    //对于聚类任​​务，这些列具有以下含义：
    //PredictedLabel 列包含预测聚类的 ID。
    //Score 列包含一个数组，其中包含到聚类质心的平方欧氏距离。数组长度等于聚类数量。
    public class ClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId;

        [ColumnName("Score")]
        public float[]? Distances;
    }
}
