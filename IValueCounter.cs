using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons11
{

    internal interface IValueCounter
    {

        // აბრუნებს უნიკალური მნიშვნელობების რაოდენობას
        int CountDistinct();

        // აბრუნებს valueToCompare-ის ტოლი მნიშვნელობების რაოდენობას
        int EqualToValue(int valueToCompare);
    }
}
