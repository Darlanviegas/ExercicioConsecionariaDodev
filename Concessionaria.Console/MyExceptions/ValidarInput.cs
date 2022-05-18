namespace Concessionaria.web.MyExceptions
{
    public class ValidarInput : Exception
    {
        public ValidarInput()
        {

        }
        public ValidarInput(string msg) : base(msg)
        {
            
        }
    }
}