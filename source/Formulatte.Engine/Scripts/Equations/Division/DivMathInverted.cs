﻿using Formulatte.Engine.Scripts.Equations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formulatte.Engine.Scripts.Equations.Division
{
    public class DivMathInverted : DivMath
    {
        public DivMathInverted(EquationContainer parent)
            : base(parent)
        {
            divMathSign.IsInverted = true;
        }

        protected override void AdjustVertical()
        {
            insideEquation.Top = Top + VerticalGap;
            divMathSign.Bottom = Bottom;
        }

        public override double RefY
        {
            get
            {
                return insideEquation.LastRow.MidY - Top;
            }
        }
    }
}
