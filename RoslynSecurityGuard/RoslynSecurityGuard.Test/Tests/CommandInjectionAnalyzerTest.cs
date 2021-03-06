﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoslynSecurityGuard.Analyzers;
using TestHelper;

namespace RoslynSecurityGuard.Tests
{

    [TestClass]
    public class CommandInjectionAnalyzerTest : DiagnosticVerifier
    {

        protected override DiagnosticAnalyzer GetCSharpDiagnosticAnalyzers()
        {
            return new CommandInjectionAnalyzer();
        }

        //No diagnostics expected to show up
        [TestMethod]
        public void CommandInjectionFalsePositive()
        {
            var test = @"
using System;
using System.Diagnostics;

namespace VulnerableApp
{
    class ProcessExec
    {
        static void TestCommandInject(string input)
        {
                Process.Start(""dir"");
        }
    }
}
";
            VerifyCSharpDiagnostic(test);
        }

        //Diagnostic and CodeFix both triggered and checked for
        [TestMethod]
        public void CommandInjectionVulnerable1()
        {
            var test = @"
using System;
using System.Diagnostics;

namespace VulnerableApp
{
    class ProcessExec
    {
        static void TestCommandInject(string input)
        {
            Process.Start(input);
        }
    }
}
        ";

            var expected = new DiagnosticResult
            {
                Id = "SG0001",
                Severity = DiagnosticSeverity.Warning,
                
            };

            VerifyCSharpDiagnostic(test, expected);
        }
    }
}