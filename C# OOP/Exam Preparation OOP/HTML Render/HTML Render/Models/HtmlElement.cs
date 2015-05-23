
namespace HTML_Render.Models
{
    using HTMLRenderer;
    using System.Collections.Generic;
    using System.Text;
    public class HtmlElement : IElement
    {
        private string textContent;
        private IList<IElement> childElements;
        public HtmlElement(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }
        public HtmlElement(string name,string textContent)
            :this(name)
        {
            this.TextContent = textContent;
        }
        public string Name { get; private set; }
     

        //TODO 
        public virtual string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }

        public virtual IEnumerable<IElement> ChildElements
        {
            get 
            {
                return new List<IElement>(this.childElements);
            }
        }

        public  virtual void AddElement(IElement element)
        {
            childElements.Add(element);
        }
       //TODO
        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrEmpty(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);                
            }
            if (!string.IsNullOrEmpty(this.textContent))
            {
                foreach (var symbol in this.textContent)
                {
                    switch (symbol)
                    {
                        case '<': output.Append("&lt;");
                            break;
                        case '>': output.Append("&gt;");
                            break;
                        case '&': output.Append("&amp;");
                            break;
                        default:
                            output.Append(symbol);
                            break;
                    }
                }
            }
            if (childElements.Count > 0)
            {
                foreach (var element in this.childElements)
                {
                    output.Append(element.ToString());
                }
            }
            if (!string.IsNullOrEmpty(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }           
            //<(name)>(text_content)(child_content)</(name)>
        }
        //TODO
        public override string ToString()
        {
            var output = new StringBuilder();
            this.Render(output);
            return output.ToString();
        }
    }
}
