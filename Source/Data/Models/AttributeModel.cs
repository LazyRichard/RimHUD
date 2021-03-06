﻿using Verse;

namespace RimHUD.Data.Models
{
    internal abstract class AttributeModel
    {
        public abstract bool Hidden { get; }

        public abstract string Label { get; }
        public abstract TipSignal? Tooltip { get; }

        protected PawnModel Model { get; }

        protected AttributeModel(PawnModel model) => Model = model;
    }
}
