using Question3.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    static class TestStartData
    {
        internal static readonly StudentData case1 = new StudentData
        {
            STG = 0.8f,  // High study time goal
            SCG = 0.7f,  // Good course goal
            STR = 0.6f,  // Above average study time
            LPR = 0.5f,  // Average lesson presentation
            PEG = 0.9f   // Excellent performance expectation
        };

        internal static readonly StudentData case2 = new StudentData
        {
            STG = 0.9f,
            SCG = 0.2f,
            STR = 0.3f,
            LPR = 0.2f,
            PEG = 0.3f
        };

        // Case 2: Strong PEG but weak other features
        internal static readonly StudentData case3 = new StudentData
        {
            STG = 0.2f,
            SCG = 0.3f,
            STR = 0.2f,
            LPR = 0.3f,
            PEG = 0.9f
        };
    }
}
