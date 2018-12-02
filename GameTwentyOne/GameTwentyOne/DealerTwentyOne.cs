using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTwentyOne
{
    public class DealerTwentyOne : Dealer
    {
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
        public List<Card> Hand { get; set; }

    }
}
