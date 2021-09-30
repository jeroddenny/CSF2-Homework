﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Vehicle
    {
        //fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        //constrctors
        public Vehicle() { }
        public Vehicle(string Make, string Model, int Year, float weight)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Weight = _weight;
        }

        public override string ToString()
        {
            return string.Format($"Vehicle: \nMake: {Make} \nModel: {Model} \nYear: {Year} \nWeight: {Weight};");
        }

        //methods
    }
}