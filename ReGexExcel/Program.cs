using System.Text.RegularExpressions;

var text = "24|AOSB690325KU0|103107247228115C24089|BERTHA APONTE SALDAÑA|SOCONUSCO|103||AGUACATAL||NUEVO LEON Y PESTALOZZI|33|2024|6|612|20|2024|6|612|||||||||||||||||||||||||06|2024/07/31|91130|87|";


var textClean = Regex.Replace(text, @"[a-zA-Z-0-9\u0020|/,]", "");

Console.WriteLine(textClean);



Console.WriteLine("Hello, World!");
