﻿using System.Collections.Generic;

namespace Jeorje
{
    public class NDAndI : NDRule
    {
        public static string _name = "and_i";
        public override string Name => _name;

        public sealed override string Label { get; set; }
        public sealed override AST Predicate { get; set; }
        public sealed override List<string> Requirements { get; set; }

        public NDAndI(string label, AST predicate, List<string> requirements)
        {
            Label = label;
            Requirements = requirements;
            Predicate = predicate;
        }
        
        public override bool CheckRule(SymbolTable symbolTable, List<AST> premises)
        {
            throw new System.NotImplementedException();
        }
    }
}