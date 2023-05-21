// See https://aka.ms/new-console-template for more information


using System.IO;
using System.Reflection;

string contentRootPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
string audioFilePath = Path.Combine(contentRootPath, "Duim.wav");

Console.WriteLine($"Path: {audioFilePath}");