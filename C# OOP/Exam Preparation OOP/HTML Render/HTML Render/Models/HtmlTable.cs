
namespace HTML_Render.Models
{
    using HTMLRenderer;
    using System;
using System.Collections.Generic;
using System.Text;
    public class HtmlTable : HtmlElement, ITable , IElement
    {
        private const string tableName = "table";
        private int rows;
        private int cols;
        private IElement[,] cells;
        public HtmlTable(int rows, int cols)
            :base(tableName)
        {
            this.Rows = rows;
            this.Cols = cols;
        }
        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value <=0 )
                {
                   throw  new ArgumentOutOfRangeException("Rows must be positive number");
                }
            }
        }
        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value <= 0 )
                {
                   throw  new ArgumentOutOfRangeException("Rows must be positive number");
                }
            }
        }
        public override IEnumerable<IElement> ChildElements
        {
            get
            {
                throw new InvalidOperationException("Table don't have ChildElements");
            }
        }
        public override string TextContent
        {
	        get 
                { 
                            throw new InvalidOperationException("Table don't have TextContent");
                }
	        set 
                { 
                            throw new InvalidOperationException("Table don't have TextContent");
                }
        }
  
        public IElement this[int row, int col]
        {
            get
            {
                this.ValidateIndecies(row, col);
                return this.cells[row, col];
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.ValidateIndecies(row, col);
                this.cells[row, col] = value;
            }
        }
        public override void AddElement(IElement element)
            {
 	             throw new InvalidOperationException("Table can't add elements");
            }
        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>",this.Name);
            
            for (int row = 0; row < this.Rows; row++)
			{
			 output.Append("<tr>");
                for (int col = 0; col < this.Cols; col++)
		        {
			        output.Append("<td>");
                    output.Append(this.cells[row,col].ToString());
                    output.Append("</td>");
		        }
             output.Append("</tr>");
			}            
            output.AppendFormat("</{0}>",this.Name);
        }
        private void ValidateIndecies(int row, int col)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (col < 0 || row >= this.Cols)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

    }
} 
