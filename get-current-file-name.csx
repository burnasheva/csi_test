string GetCurrentFileName([System.Runtime.CompilerServices.CallerFilePath] string fileName = null)
{
    return fileName;
}
Console.WriteLine($"csxpath={GetCurrentFileName()}");
