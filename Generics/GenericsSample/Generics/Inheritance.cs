namespace GenericsSample.Generics
{
    #region Inheritance
    public class Parent<TInput, TOutput>
    {
    }

    public class Child : Parent<int, string>
    {

    }

    public class Child<TInput> : Parent<TInput, string>
    {

    }

    public class Child<TInput, TOutput> : Parent<TInput, TOutput>
    {

    } 
    #endregion
}
