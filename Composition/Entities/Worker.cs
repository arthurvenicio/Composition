using System;
using System.Collections.Generic;
using Composition.Entities.Enums;

namespace Composition.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Worker() { }
        public Worker(string name, WorkerLevel level, double baseSalary) 
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
        }

    }
}
