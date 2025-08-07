
/*namespace SolutionTests {
    using NUnit.Framework;
    using System;
    using System.Linq;
    using Kata;
    
    // Use TDD by writing your own tests

    [TestFixture]
    class SampleTests
    {
        [Test]
        public void SimpleCases()
        {
            var cases = new[] {
                ("", new string[0][]),
                ("Yes", new[] { new[] {"Yttrium (Y)", "Einsteinium (Es)"} }),
                ("beach", new[] { new[] {"Beryllium (Be)", "Actinium (Ac)", "Hydrogen (H)"} }),
                ("snack", new[] {
                    new[] {"Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"},
                    new[] {"Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"},
                    new[] {"Tin (Sn)", "Actinium (Ac)", "Potassium (K)"}
                }),
            };
            foreach (var (word, expected) in cases) {
                var actual = ElementalWords.ElementalForms(word);
                Assert.That(actual, Is.EquivalentTo(expected), $"Unexpected result for word: {word}");
            }
        }
    }
}*/

using Core;

namespace Core.Tests;

public class ElementalWordsTests
{
    [Fact]
    public void EmptyStringReturnsEmptyArray()
    {
        var word = string.Empty;
        var result = ElementalWords.ElementalForms(word);
        Assert.Empty(result);
    }

    [Fact]
    public void WordTooLongReturnsEmptyArray()
    {
        var word = "somethingverylong";
        var result = ElementalWords.ElementalForms(word);
        Assert.Empty(result);
    }

    [Fact]
    public void SplitSplitsUpTheWordIntoParts()
    {
        var word = "SNACK";
        var result = ElementalWords.Parts(word, 3);
        Assert.Equal(13, result.Length);
        Assert.Equal(["S", "N", "A", "C", "K"], result[0]);
        Assert.Equal(["SNA", "CK"], result[12]);
    }

    [Fact]
    public void ElementalFormsFindsAllElements()
    {
        var word = "SNACK";
        var result = ElementalWords.ElementalForms(word);
        Assert.Equal(3, result.Length);
        Assert.Equal(["Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"], result[0]);
        Assert.Equal(["Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"], result[1]);
        Assert.Equal(["Tin (Sn)", "Actinium (Ac)", "Potassium (K)"], result[2]);
    }
}