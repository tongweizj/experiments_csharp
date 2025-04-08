using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.data
{
    public class StudentData
    {
        [LoadColumn(0)]
        public float STG { get; set; }  // Study Time Goal

        [LoadColumn(1)]
        public float SCG { get; set; }  // Study Course Goal

        [LoadColumn(2)]
        public float STR { get; set; }  // Study Time Related

        [LoadColumn(3)]
        public float LPR { get; set; }  // Lesson Presentation

        [LoadColumn(4)]
        public float PEG { get; set; }  // Performance Expectation Grade
    }


    public class ClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId { get; set; }

        [ColumnName("Score")]
        public float[] Distances { get; set; }
    }

}