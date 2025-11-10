namespace Backend.Tests;

public class MorseDictTests
{
    [Fact]
    public void Test_CharToMorse_Mapping()
    {
        // Test known mappings
        Assert.Equal(".-", MorseDict.CharToMorse['A']);
        Assert.Equal("-...", MorseDict.CharToMorse['B']);
        Assert.Equal("-.-.", MorseDict.CharToMorse['C']);
        Assert.Equal("-..", MorseDict.CharToMorse['D']);
        Assert.Equal(".", MorseDict.CharToMorse['E']);
        Assert.Equal("..-.", MorseDict.CharToMorse['F']);
        Assert.Equal("--.", MorseDict.CharToMorse['G']);
        Assert.Equal("....", MorseDict.CharToMorse['H']);
        Assert.Equal("..", MorseDict.CharToMorse['I']);
        Assert.Equal(".---", MorseDict.CharToMorse['J']);
        Assert.Equal("-.-", MorseDict.CharToMorse['K']);
        Assert.Equal(".-..", MorseDict.CharToMorse['L']);
        Assert.Equal("--", MorseDict.CharToMorse['M']);
        Assert.Equal("-.", MorseDict.CharToMorse['N']);
        Assert.Equal("---", MorseDict.CharToMorse['O']);
        Assert.Equal(".--.", MorseDict.CharToMorse['P']);
        Assert.Equal("--.-", MorseDict.CharToMorse['Q']);
        Assert.Equal(".-.", MorseDict.CharToMorse['R']);
        Assert.Equal("...", MorseDict.CharToMorse['S']);
        Assert.Equal("-", MorseDict.CharToMorse['T']);
        Assert.Equal("..-", MorseDict.CharToMorse['U']);
        Assert.Equal("...-", MorseDict.CharToMorse['V']);
        Assert.Equal(".--", MorseDict.CharToMorse['W']);
        Assert.Equal("-..-", MorseDict.CharToMorse['X']);
        Assert.Equal("-.--", MorseDict.CharToMorse['Y']);
        Assert.Equal("--..", MorseDict.CharToMorse['Z']);
        Assert.Equal("-----", MorseDict.CharToMorse['0']);
        Assert.Equal(".----", MorseDict.CharToMorse['1']);
        Assert.Equal("..---", MorseDict.CharToMorse['2']);
        Assert.Equal("...--", MorseDict.CharToMorse['3']);
        Assert.Equal("....-", MorseDict.CharToMorse['4']);
        Assert.Equal(".....", MorseDict.CharToMorse['5']);
        Assert.Equal("-....", MorseDict.CharToMorse['6']);
        Assert.Equal("--...", MorseDict.CharToMorse['7']);
        Assert.Equal("---..", MorseDict.CharToMorse['8']);
        Assert.Equal("----.", MorseDict.CharToMorse['9']);
        Assert.Equal(".-.-.-", MorseDict.CharToMorse['.']);
        Assert.Equal("--..--", MorseDict.CharToMorse[',']);
        Assert.Equal("..--..", MorseDict.CharToMorse['?']);
        Assert.Equal(".----.", MorseDict.CharToMorse['\'']);
        Assert.Equal("-.-.--", MorseDict.CharToMorse['!']);
        Assert.Equal("-..-.", MorseDict.CharToMorse['/']);
        Assert.Equal("-.--.", MorseDict.CharToMorse['(']);
        Assert.Equal("-.--.-", MorseDict.CharToMorse[')']);
        Assert.Equal(".-...", MorseDict.CharToMorse['&']);
        Assert.Equal("---...", MorseDict.CharToMorse[':']);
        Assert.Equal("-.-.-.", MorseDict.CharToMorse[';']);
        Assert.Equal("-...-", MorseDict.CharToMorse['=']);
        Assert.Equal(".-.-.", MorseDict.CharToMorse['+']);
        Assert.Equal("-....-", MorseDict.CharToMorse['-']);
        Assert.Equal("..--.-", MorseDict.CharToMorse['_']);
        Assert.Equal(".-..-.", MorseDict.CharToMorse['"']);
        Assert.Equal("...-..-", MorseDict.CharToMorse['$']);
        Assert.Equal(".--.-.", MorseDict.CharToMorse['@']);
    }
}