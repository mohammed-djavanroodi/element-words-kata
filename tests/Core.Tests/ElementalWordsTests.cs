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
        var result = ElementalWords.Parts("SNACK", 3);
        Assert.Equal(13, result.Length);
        Assert.Equal(["S", "N", "A", "C", "K"], result[0]);
        Assert.Equal(["SNA", "CK"], result[12]);

        result = ElementalWords.Parts("YES", 3);
        Assert.Equal(4, result.Length);
        Assert.Equal(["Y", "E", "S"], result[0]);
        Assert.Equal(["Y", "ES"], result[1]);
        Assert.Equal(["YE", "S"], result[2]);
        Assert.Equal(["YES"], result[3]);
    }

    [Fact]
    public void ElementalFormsFindsAllElements()
    {
        var result = ElementalWords.ElementalForms("SNACK");
        Assert.Equal(3, result.Length);
        Assert.Equal(["Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"], result[0]);
        Assert.Equal(["Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"], result[1]);
        Assert.Equal(["Tin (Sn)", "Actinium (Ac)", "Potassium (K)"], result[2]);
    }

    [Fact]
    public void ElementalFormsIsCaseInsensitive()
    {
        var result = ElementalWords.ElementalForms("snack");
        Assert.Equal(3, result.Length);
        Assert.Equal(["Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"], result[0]);
        Assert.Equal(["Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"], result[1]);
        Assert.Equal(["Tin (Sn)", "Actinium (Ac)", "Potassium (K)"], result[2]);
    }
}