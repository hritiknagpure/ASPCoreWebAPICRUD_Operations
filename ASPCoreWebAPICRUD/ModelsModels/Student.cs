using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD.ModelsModels
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Studentname { get; set; } = null!;
        public int? Age { get; set; }
        public string? Standard { get; set; }
        public string? Fathername { get; set; }
        //public string Name { get; internal set; }
    }
}
