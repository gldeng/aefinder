using System.Collections.Generic;

namespace AeFinder.DevelopmentTemplate;

public class DevTemplateOptions
{
    public string TemplatePath { get; set; } = "/Users/zx/Downloads/aefinder-test/dev-template";
    public string ProjectPlaceholder { get; set; } = "AppTemplate";
    public List<string> ReplaceExtensions { get; set; } = new() { ".cs", ".csproj", ".sln" };
    public List<string> ProjectExtensions { get; set; } = new() { ".csproj", ".sln" };
    
}