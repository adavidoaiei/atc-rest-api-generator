using System;
using System.Collections.Generic;
using System.Text;
using Atc.Rest.ApiGenerator.Helpers;

namespace Atc.Rest.ApiGenerator.Tests.Helpers
{
    public static class GeneratorOutput
    {
        private static readonly string ToolName = "ApiGenerator";

        public static readonly string GeneratorAtcComment = @$"
//------------------------------------------------------------------------------
// This code was auto-generated by {ToolName} {GenerateHelper.GetAtcToolVersion()}.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
".Trim();

        public static readonly string GeneratorClassAttribute = $@"
[GeneratedCode(""{ToolName}"", ""{GenerateHelper.GetAtcToolVersion()}"")]
".Trim();
    }
}