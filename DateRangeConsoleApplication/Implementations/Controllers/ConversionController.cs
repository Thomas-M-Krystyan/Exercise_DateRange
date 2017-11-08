﻿using System;
using System.Globalization;

namespace DateRangeConsoleApplication.Implementations.Controllers
{
    internal class ConversionController
    {
        private readonly CultureInfo _currentCulture;

        internal ConversionController(CultureInfo currentCulture)
        {
            this._currentCulture = currentCulture;
        }

        internal DateTime[] ProcessInputArray(string[] inputArray)
        {
            DateTime[] convertedDateArray = ConvertStringsToDateTime(inputArray);
            
            return convertedDateArray;
        }

        private DateTime[] ConvertStringsToDateTime(string[] inputArray)
        {
            int inputArrayLength = inputArray.Length;
            DateTime[] convertedDateArray = new DateTime[inputArrayLength];

            DateTime date;
            for (int i = 0; i < inputArrayLength; i++)
            {
                ValidationController.TryParseToDate(inputArray[i], this._currentCulture, out date);
                convertedDateArray[i] = date;
            }

            return convertedDateArray;
        }
    }
}