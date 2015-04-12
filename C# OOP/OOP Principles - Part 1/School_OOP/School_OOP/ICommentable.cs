using System.Collections;
using System.Collections.Generic;
namespace School_OOP
{
    public interface ICommentable
    {
       List<string> Comments { get; }
       void AddComments(string comment);
       string AllComments();
    }
}
