using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WixSharp
{
    public class ProjectReference
    {
        public string Name { get; }

        public string SourceDir { get; set; }

        public string TargetDir { get; set; }

        public string ProjectPath { get; }

        public bool Binaries { get; set; } = true;

        public bool Content { get; set; } = true;

        public bool Satellites { get; set; } = true;


        public ProjectReference(string projectPath)
        {
            ProjectPath = projectPath;
            Name = Path.GetFileNameWithoutExtension(projectPath);
        }
    }
}