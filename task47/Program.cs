using System.Globalization;

const int wight = 4;
const int height = 3;
IEnumerable<string> generateArrayOfRandomFloats = 

    GenerateArrayOfRandomFloats(wight, height)
        .SelectMany(x => x )
        .Select((x, index) => index % wight ==0
            ? "\n" + FloatToString(x)
            : FloatToString(x));

Console.WriteLine(string.Join(", ", generateArrayOfRandomFloats));

float[][] GenerateArrayOfRandomFloats(int wightParam, int heightParam)
{
    float[][] randomNumbers = new float[wightParam][];
    for (int i = 0; i < wightParam; i++)
    {
        randomNumbers[i] = new float[heightParam];
        for (int j = 0; j < heightParam; j++)
            randomNumbers[i][j] = RandomFloat(-100, 100);
    }
    return randomNumbers;
}

string FloatToString(float f)
{
    return f.ToString("0,00", CultureInfo.InvariantCulture);
}

float RandomFloat(int minValue, int maxValue)
{
    return Random.Shared.Next(minValue + 1, maxValue) + Random.Shared.NextSingle();
}