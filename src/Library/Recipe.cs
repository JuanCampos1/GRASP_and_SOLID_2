//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public ArrayList step
        {
            get
            {
                return steps;
            }
        }

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        
        public double productCost{get; set; }
        public double equipmentCost{get; set; }
        public double totalCost{get; set; }
        public double GetProductionCost()
        {
            foreach (Step step in steps)
            {
                productCost = step.Input.UnitCost * step.Quantity + productCost;
                equipmentCost = step.Quantity * step.Time + equipmentCost;
            }
            totalCost = productCost + equipmentCost;
            return totalCost;
        }
    }
}