﻿using Formulatte.Engine.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formulatte.Engine.Scripts.Equations.SignComposite
{
    public static class SignCompositeFactory
    {
        public static EquationBase CreateEquation(EquationContainer equationParent, Position position, SignCompositeSymbol symbol, bool useUpright)
        {
            EquationBase equation = null;
            switch (position)
            {
                case Position.None:
                    equation = new SignSimple(equationParent, symbol, useUpright);
                    break;
                case Position.Bottom:
                    equation = new SignBottom(equationParent, symbol, useUpright);
                    break;
                case Position.BottomAndTop:
                    equation = new SignBottomTop(equationParent, symbol, useUpright);
                    break;
                case Position.Sub:
                    equation = new SignSub(equationParent, symbol, useUpright);
                    break;
                case Position.SubAndSuper:
                    equation = new SignSubSuper(equationParent, symbol, useUpright);
                    break;
            }
            return equation;
        }
    }
}
