//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, 
//product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//delegate for the method which will be passed to retrieve the required numeral value
//for executing the methods Sum, Average, Product for user defined types
public delegate decimal CustomTypeNumericalValue<T>(T ob);

public static class IEnumerableExtensions
{

    //this version is for numeral types
    public static decimal Sum<T>(this IEnumerable<T> en) where T : struct, IConvertible, IComparable<T>
    //with these constraints only numerical types will work (AND any other user defined types which implement those interfaces)
    {
        decimal sum = 0;
        foreach (T element in en)
        {
            dynamic e = element;
            sum = sum + e;
        }
        return sum;
    }


    //this version is for user defined types (classes structures etc)
    public static decimal Sum<T>(this IEnumerable<T> en, CustomTypeNumericalValue<T> numericalVal)
    {
        decimal sum = 0;
        foreach (T element in en)
        {
            dynamic e = element;
            sum = sum + numericalVal(element);
        }
        return sum;
    }
    //all the following methods follow the same principle


    public static decimal Average<T>(this IEnumerable<T> en) where T : struct, IConvertible, IComparable<T>
    {
        decimal sum = 0;
        int count = 0;
        foreach (T element in en)
        {
            dynamic e = element;
            sum = sum + e;
            count++;
        }
        return sum / count;
    }


    public static decimal Average<T>(this IEnumerable<T> en, CustomTypeNumericalValue<T> numericalVal)
    {
        decimal sum = 0;
        int count = 0;
        foreach (T element in en)
        {
            dynamic e = element;
            sum = sum + numericalVal(element);
            count++;
        }
        return sum / count;
    }


    public static decimal Product<T>(this IEnumerable<T> en) where T : struct, IConvertible, IComparable<T>
    {
        decimal product = 1;
        foreach (T element in en)
        {
            dynamic e = element;
            product = product * e;
        }
        return product;
    }


    public static decimal Product<T>(this IEnumerable<T> en, CustomTypeNumericalValue<T> numericalVal)
    {
        decimal product = 1;
        foreach (T element in en)
        {
            dynamic e = element;
            product = product * numericalVal(element);
        }
        return product;
    }


    public static T Min<T>(this IEnumerable<T> en) where T : IComparable<T>
    {
        T min = en.First();
        foreach (T element in en)
        {
            dynamic e = element;
            if (e.CompareTo(min) < 0)
            {
                min = element;
            }
        }

        return min;
    }


    public static T Max<T>(this IEnumerable<T> en) where T : IComparable<T>
    {
        T max = en.First();
        foreach (T element in en)
        {
            dynamic e = element;
            if (e.CompareTo(max) > 0)
            {
                max = element;
            }
        }

        return max;
    }

}
