﻿using System.Linq;
using XamlCSS.CssParsing;
using XamlCSS.Dom;

namespace XamlCSS
{
    public class LastChildMatcher : SelectorMatcher
    {
        public LastChildMatcher(CssNodeType type, string text) : base(type, text)
        {
        }

        public override MatchResult Match<TDependencyObject, TDependencyProperty>(StyleSheet styleSheet, ref IDomElement<TDependencyObject, TDependencyProperty> domElement, SelectorMatcher[] fragments, ref int currentIndex)
        {
            return domElement.LogicalParent?.LogicalChildNodes.IndexOf(domElement) == (domElement.LogicalParent?.LogicalChildNodes.Count()) - 1 ? MatchResult.Success : MatchResult.ItemFailed;
        }
    }
}
