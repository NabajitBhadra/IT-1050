using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class AverageAge
    {
        private double _sumOfAllAges;
        private double _totalNumberOfPeople;

        public double Get()
        {
            return (double)_sumOfAllAges / (double)_totalNumberOfPeople;
        }

        public void AddPerson(Person personPlus)
        {
            _totalNumberOfPeople = _totalNumberOfPeople + 1;
            _sumOfAllAges = _sumOfAllAges + personPlus.Age;

            if (personPlus.Married)
            {
                _totalNumberOfPeople++;
                _sumOfAllAges = _sumOfAllAges += personPlus.Spouse.Age;
            }
        }
    }
}

