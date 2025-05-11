using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace EnumLengthGenerator
{
    public class GenerateEnumLengthAttributeSyntaxReceiver : ISyntaxReceiver
    {
        public List<EnumDeclarationSyntax> Syntaxes { get; } = new List<EnumDeclarationSyntax>();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is EnumDeclarationSyntax enumDeclaration)
            {
                if (!this.HasGenertateEnumLengthAttribute(enumDeclaration)) return;
                this.Syntaxes.Add(enumDeclaration);
            }
                
        }

        private bool HasGenertateEnumLengthAttribute(EnumDeclarationSyntax enumDeclaration)
        {
            const string attributeName = "GenerateEnumLength";

            return enumDeclaration.AttributeLists.Any(
                attributeList => attributeList.Attributes.Any(
                    attribute => attribute.Name.ToString() == attributeName));

        }

    }

}