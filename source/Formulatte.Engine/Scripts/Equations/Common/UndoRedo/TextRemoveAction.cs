﻿using Formulatte.Engine.Common;
using Formulatte.Engine.Scripts.Equations.Common.UndoRedo;
using Formulatte.Engine.Scripts.Equations.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formulatte
{
    public class TextRemoveAction : EquationAction
    {
        public int Index { get; set; }
        public string Text { get; set; }
        public int[] Formats { get; set; }
        public EditorMode[] Modes { get; set; }
        public CharacterDecorationInfo[] Decorations { get; set; }
        public int SelectionStartIndex { get; set; }
        public int SelectionCount { get; set; }
        public int ParentSelectionStartIndex { get; set; }

        public TextRemoveAction(ISupportsUndo executor, int index, string text, int selectionStartIndex,
                                int selectionCout, int parentSelectionStartIndex, int[] formats, EditorMode[] modes, 
                                CharacterDecorationInfo[] decorations)
            : base(executor)
        {
            Index = index;
            Text = text;
            Formats = formats;
            Modes = modes;
            Decorations = decorations;
            SelectionStartIndex = selectionStartIndex;
            SelectionCount = selectionCout;
            ParentSelectionStartIndex = parentSelectionStartIndex;
        }
    }    
}
