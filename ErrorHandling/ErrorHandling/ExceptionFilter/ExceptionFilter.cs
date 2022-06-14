namespace ErrorHandling.ExceptionFilter
{
    #region Description
    /// <summary>
    /// توی سی شارپ 6 اضافه شد که این امکان رو به ما میده که یک بلاک کچ رو روش شرط بزاریم و با یک شرط واردش بشیم اگر اون
    /// شرط درست بود اون کچ اتفاق بیوفته،
    /// </summary> 
    #endregion
    #region ExceptionFilter
    public class ExceptionFilter
    {
        public void ExceptionFilterSample()
        {

            try
            {
                // To Do
            }
            catch (ArgumentException ex) when (ex.InnerException != null)
            {

            }
            catch (InvalidOperationException ex) when (DateTime.Now.Hour == 2)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
    } 
    #endregion
}
