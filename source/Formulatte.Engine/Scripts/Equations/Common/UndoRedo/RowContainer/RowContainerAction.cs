﻿using Formulatte.Engine.Scripts.Equations;
using Formulatte.Engine.Scripts.Equations.Common.UndoRedo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formulatte.Engine.Scripts.Equations.Common.UndoRedo.RowContainer
{
    public class RowContainerAction : EquationAction
    {
        public int Index { get; set; }
        public int ChildIndexInRow { get; set; }
        public int CaretIndex { get; set; }
        public EquationRow Equation { get; set; }
        public bool Added { get; set; }

        public RowContainerAction(ISupportsUndo executor, int index, int childIndexInRow, int caretIndex, bool added, EquationRow equation)
            : base(executor)
        {
            Index = index;
            ChildIndexInRow = childIndexInRow;
            CaretIndex = caretIndex;
            Equation = equation;
            Added = added;
        }

        public RowContainerAction(ISupportsUndo executor, int index, int childIndexInRow, int caretIndex, EquationRow equation) : base(executor)
        {
            Index = index;
            ChildIndexInRow = childIndexInRow;
            CaretIndex = caretIndex;
            Equation = equation;
        }
    }
}

