using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IterationSample
{
     class IterationSample : IEnumerable
    {

        object[] values;
        int startId;
        public IterationSample(object[] values, int startId)
        {
            this.values = values;
            this.startId = startId;

        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < values.Length; i++)
            {
                yield return values[(i + startId) % values.Length];
            }
        }
    }
}
