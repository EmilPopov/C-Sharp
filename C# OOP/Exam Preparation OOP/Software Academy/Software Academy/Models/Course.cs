
namespace Software_Academy.Models
{
    using SoftwareAcademy;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public abstract class Course : ICourse
    {
        private string name;
        private ICollection<string> sequenceOfTopics;
        public Course(string name,ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.sequenceOfTopics = new List<string>();
        }
       
        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }


        public ITeacher Teacher { get; set; }
      

        public void AddTopic(string topic)
        {
            sequenceOfTopics.Add(topic);
        }
        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);
            if (this.Teacher != null)
            {
                output.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }
            if (this.sequenceOfTopics.Count > 0)
            {
                output.AppendFormat("; Topics=[{0}]", string.Join(", ",this.sequenceOfTopics));
            }
            return output.ToString();
            //(course type): Name=(course name); Teacher=(teacher name); Topics=[(course topics – comma
            //separated)]; Lab=(lab name – when applicable); Town=(town name – when applicable);
        }
    }
}
